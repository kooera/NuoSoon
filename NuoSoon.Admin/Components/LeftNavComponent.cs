using Microsoft.AspNetCore.Mvc;
using NuoSoon.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vli.Entity.PO;

namespace NuoSoon.Admin.Components
{
    [ViewComponent(Name = "leftnav")]
    public class LeftNavComponent : ViewComponent
    {
        private readonly NsDb db;
        private List<string> navIds;

        public LeftNavComponent(NsDb db)
        {
            this.db = db;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            try
            {
                navIds = new List<string>();
                ViewBag.str = await GetNav();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("获取左侧菜单错误！", ex);
            }

            return View();
        }

        private List<string> GetParent(List<string> code, List<Navigation> navigations, int idParent)
        {
            var item = navigations.Where(x => x.Id == idParent).FirstOrDefault();
            if (item == null || item.Id == 0)
            {
                return code;
            }

            code.Add(item.Code);
            if (item.IdParent != 0)
            {
                GetParent(code, navigations, item.IdParent);
            }
            return code;
        }

        private Task<string> GetNav()
        {
            var navList = db.Navigation.Where(x => x.IsLock == false);


            StringBuilder navHtml = new StringBuilder();
            navHtml.Append("<ul class='sidebar-menu' data-widget='tree'>");
            navHtml.Append("<li class='header'>主菜单</li>");

            if (navList != null)
            {
                var navLi = navList.OrderBy(x => x.Sort).ToList();
                var url = Request.Path.ToString();
                int id = 0;
                foreach (var item in navLi)
                {
                    if (url.Replace("/", "").ToLower().Contains(item.Url.Replace("/", "").ToLower()))
                    {
                        id = item.IdParent;
                        navIds.Add(item.Code);
                        break;
                    }
                }

                navIds = GetParent(navIds, navLi, id);

                GetNavigation(navLi, 0, navHtml);
            }

            navHtml.Append("</ul>");

            return Task.FromResult(navHtml.ToString());
        }

        private void GetNavigation(List<Navigation> oldList, long idParent, StringBuilder builder)
        {
            if (oldList == null || oldList.Count == 0)
            {
                return;
            }
            var root = oldList.Where(x => x.IdParent == idParent);

            // 存在下级
            if (root.Any())
            {
                foreach (var item in root)
                {
                    var hasChild = oldList.Where(x => x.IdParent == item.Id).Any();
                    var active = navIds.Contains(item.Code) == true ? "active" : "";

                    if (hasChild)
                    {
                        builder.Append($"<li class='treeview {active}' navid='{item.Code}'>");
                    }
                    else
                    {
                        builder.Append($"<li class='{active}' navid='{item.Code}'>");
                    }

                    if (hasChild)
                    {
                        builder.Append($"<a>");
                    }
                    else
                    {
                        builder.Append($"<a href='{item.Url}'>");
                    }

                    if (item.IconUrl != null)
                    {
                        builder.Append($"<i class='{item.IconUrl.Replace(".", "")}'></i>");
                    }
                    else
                    {
                        builder.Append($"<i class='icon iconfont icon-loading'></i>");
                    }

                    if (hasChild)
                    {
                        builder.Append($"<span> {item.Name}</span><span class='pull-right-container'><i class='fa fa-angle-left pull-right'></i></span></a>");
                    }
                    else
                    {
                        builder.Append($"<span> {item.Name}</span></a>");
                    }

                    if (hasChild)
                    {
                        builder.Append("<ul class='treeview-menu'>");
                    }

                    GetNavigation(oldList, item.Id, builder);

                    if (hasChild)
                    {
                        builder.Append("</ul>");
                    }

                    builder.Append("</li>");
                }

            }
            else
            {
                foreach (var item in root)
                {
                    var active = navIds.Contains(item.Code) == true ? "active" : "";
                    if (!string.IsNullOrEmpty(item.IconUrl))
                    {
                        builder.Append($"<li class='{active}' navid='{item.Code}'><a href='{item.Url}'><i class='{item.IconUrl.Replace(".", "")}'></i> <span> {item.Name}</span></a></li>");
                    }
                    else
                    {
                        builder.Append($"<li class='{active}' navid='{item.Code}'><a href='{item.Url}'><i class='icon iconfont icon-news_hot_light'></i> <span> {item.Name}</span></a></li>");
                    }
                }
            }
        }
    }
}
