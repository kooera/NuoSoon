using Microsoft.AspNetCore.Mvc;
using NuoSoon.Admin.Models;
using NuoSoon.Service;
using System.Diagnostics;
using Vli.Entity.PO;

namespace NuoSoon.Admin.Controllers
{
    public class HomeController : Controller
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
