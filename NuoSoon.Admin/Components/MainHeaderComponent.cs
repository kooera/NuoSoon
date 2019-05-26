using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vli.Entity.PO;

namespace NuoSoon.Admin.Components
{
    [ViewComponent(Name = "mainHeader")]
    public class MainHeaderComponent : ViewComponent
    {
        public MainHeaderComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            SystemUser model = new SystemUser();
            model.Name = HttpContext.User.Identity.Name;
            return View(model);
        }

    }
}
