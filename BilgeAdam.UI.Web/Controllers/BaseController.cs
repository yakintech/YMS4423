using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeAdam.UI.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.UserName = HttpContext.User.Identity.Name;
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }

    }
}