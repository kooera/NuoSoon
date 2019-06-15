using Microsoft.AspNetCore.Mvc;
using Vli.Core;

namespace NuoSoon.Admin.Controllers
{
    [InitNav(Name = "文章管理", Layer = 0)]
    public class AticleController : BaseController
    {        
        public IActionResult Index()
        {
            return View();
        }

        [InitNav(Name = "文章列表", Layer = 1)]
        public IActionResult List()
        {
            return View();
        }
    }
}