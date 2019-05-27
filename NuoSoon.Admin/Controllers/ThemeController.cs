using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vli.Core;

namespace NuoSoon.Admin.Controllers
{
    [InitNav(Name = "系统设置", Layer = 0)]
    public class ThemeController : Controller
    {
        [InitNav(Name = "主题设置", Layer = 1)]
        public IActionResult Index()
        {
            return View();
        }
    }
}