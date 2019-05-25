using Microsoft.AspNetCore.Mvc;
using Vli.Entity.VO;
using Vli.Extension;

namespace NuoSoon.Api.Controllers
{
    /// <summary>
    /// 文件操作
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpPost]
        public Result<string> GetId()
        {
            return new Result<string> { Data = "".Guid() };
        }
    }
}