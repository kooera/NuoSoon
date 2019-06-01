using Microsoft.AspNetCore.Mvc;
using NuoSoon.Admin.Models;
using NuoSoon.Service;
using System.Diagnostics;
using Vli.Entity.PO;

namespace NuoSoon.Admin.Controllers
{
    public class HomeController : BaseController
    {
        IAccessRecordService<AccessRecord> accessRecord;

        public HomeController(IAccessRecordService<AccessRecord> accessRecord)
        {
            this.accessRecord = accessRecord;
        }

        public IActionResult Index()
        {
            bool s = accessRecord.DeleteById(2);
            return View();
        }

    }
}
