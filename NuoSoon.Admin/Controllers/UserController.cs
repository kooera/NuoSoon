using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vli.Core;
using Vli.Entity.PO;

namespace NuoSoon.Admin.Controllers
{
    [InitNav(Name = "系统设置", Layer = 0)]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [InitNav(Name = "用户管理", Layer = 1)]
        [InitNav(Name = "用户列表", Layer = 2)]
        public IActionResult List()
        {
            return View();
        }

        public IActionResult AddOrUpdate()
        {
            SystemUser systemUser = new SystemUser();
            return View(systemUser);
        }
    }
}