/**
*
* 功 能： N/A
* 类 名： GlobalActionFilter
* 作 者： weili
* 时 间： 2019/5/23 23:02:03
* 版 本： 1.0.0.0
* 版 权： Copyright (c) 2019 Mainki. All rights reserved.
*
*/

using Microsoft.AspNetCore.Mvc.Filters;

namespace NuoSoon.Filter
{
    public class GlobalActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }
    }
}
