using Microsoft.AspNetCore.Mvc;
using NuoSoon.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using Vli.Core;
using Vli.Entity.PO;
using Vli.Entity.VO;

namespace NuoSoon.Admin.Controllers
{
    [InitNav(Name = "系统设置", Layer = 0)]
    public class NavigationController : BaseController
    {
        private readonly INavigationService<Navigation> navigationService;
        private readonly IBaseService<Navigation> baseService;

        public NavigationController(INavigationService<Navigation> navigationService, IBaseService<Navigation> baseService)
        {
            this.navigationService = navigationService;
            this.baseService = baseService;
        }
               
        public IActionResult Index()
        {
            return View();
        }

        [InitNav(Name = "后台导航", Layer = 1)]
        public IActionResult List()
        {
            return View();
        }

        [HttpPost]
        [HttpGet]
        public JsonResult InitNav()
        {
            InitNavigation();
            Result<string> result = new Result<string> { Code = "v1000", Data = "success", Message = "执行成功", Status = true };
            return Json(result);
        }

        private void InitNavigation()
        {
            var asm = System.Reflection.Assembly.GetExecutingAssembly();            
            List<Type> typeList = new List<Type>();
            var types = asm.GetTypes();
            foreach (Type type in types)
            {
                string s = type.FullName.ToLower();
                if (s.StartsWith("nuosoon.admin.controllers."))
                    typeList.Add(type);
            }

            typeList.Sort(delegate (Type type1, Type type2) { return type1.FullName.CompareTo(type2.FullName); });
            foreach (Type type in typeList)
            {
                string controller = type.Name.Replace("Controller", "");
                if (controller.StartsWith("<"))
                {
                    continue;
                }

                System.Reflection.MemberInfo[] members = type.FindMembers(System.Reflection.MemberTypes.Method,
                System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.Static |
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.DeclaredOnly,
                Type.FilterName, "*");

                Navigation topNav = new Navigation();
                object[] initNav = type.GetCustomAttributes(typeof(InitNavAttribute), false);
                if (initNav != null && initNav.Length > 0)
                {
                    foreach (InitNavAttribute item in initNav)
                    {
                        topNav.Layer = item.Layer;
                        topNav.Code = controller.ToLower();
                        topNav.Name = item.Name;
                    }
                }
                else
                {
                    continue;
                }
                topNav.Url = "/" + controller.ToLower() + "/index";
                topNav.ActionName = "Index";

                var rootData = navigationService.Navigations().FirstOrDefault(x => x.Name == topNav.Name || x.Code == topNav.Code);
                if (rootData == null || rootData.Id == 0)
                {
                    topNav.IconUrl = ".icon iconfont icon-loading";
                    topNav.Actions = "Show,View";
                    navigationService.Insert(topNav);
                }
                else
                {
                    topNav.Id = rootData.Id;
                    topNav.Code = rootData.Code;
                }
                                
                foreach (var m in members)
                {
                    if (m.DeclaringType.Attributes.HasFlag(System.Reflection.TypeAttributes.Public) != true)
                    {
                        continue;
                    }

                    string action = m.Name;
                    object[] initNavs = m.GetCustomAttributes(typeof(InitNavAttribute), false);
                    if (initNavs != null && initNavs.Length > 0)
                    {
                        Navigation tempNav = new Navigation
                        {
                            Id = topNav.Id
                        };

                        foreach (InitNavAttribute item in initNavs)
                        {
                            Navigation nav = new Navigation
                            {
                                ActionName = action,
                                Code = (controller + "_" + action + "_" + item.Layer).ToLower(),
                                ControllerName = controller,
                                Layer = item.Layer,
                                Name = item.Name,
                                Url = "/" + (controller + "/" + action).ToLower()
                            };
                            
                            var navList = navigationService.Navigations();                           
                            var subNav = navList.FirstOrDefault(x => x.Name == item.Name || x.Code == nav.Code);                           
                            if (subNav != null && subNav.Id > 0)
                            {
                                tempNav.Id = subNav.Id;
                                continue;
                            }
                            else if (item.Layer > 1)
                            {
                                nav.IdParent = tempNav.Id;
                                var sub = navList.FirstOrDefault(x => x.Id == tempNav.Id);
                                sub.Url = "#";
                                baseService.Update(sub);
                            }
                            else
                            {
                                nav.IdParent = topNav.Id;
                            }

                            nav.IconUrl = ".icon iconfont icon-loading";
                            nav.Actions = "Show,View";

                            navigationService.Insert(nav);
                            tempNav.Id = nav.Id;
                        }
                    }
                }
            }
        }
    }
}