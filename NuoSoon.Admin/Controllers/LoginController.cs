using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using Vli.Core;
using Vli.Entity.VO;
using Vli.Extension;
using Vli.Static;

namespace NuoSoon.Admin.Controllers
{   
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserInfo userInfo = new UserInfo
            {
                ReturnUrl = Request.GetValue("ReturnUrl")
            };
            return View(userInfo);
        }

        public async Task<JsonResult> CheckUserAsync(UserInfo sysUser)
        {
            Result<string> result = new Result<string>();
            if (sysUser.Name == "admin" && sysUser.Pwd == "123456789")
            {
                sysUser.AuthenticationType = CookieAuthenticationDefaults.AuthenticationScheme;
                var identity = new ClaimsIdentity(sysUser);
                identity.AddClaim(new Claim(ClaimTypes.Name, sysUser.Name));
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                result.Code = SysCode.SUCCESS_1000;
                result.Data = sysUser.ReturnUrl;
            }
            else
            {
                result.Code = "1001";
            }
            return Json(result);
        }

        [InitNav(Name = "退出", Layer = 0)]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/login");
        }
    }
}