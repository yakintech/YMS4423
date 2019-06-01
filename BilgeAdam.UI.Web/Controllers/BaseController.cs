using BilgeAdam.Business.Repository;
using BilgeAdam.Data.ORM.Entity;
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

        public GenericRepository<Product> rpproduct;
        public GenericRepository<Category> rpcategory;
        public GenericRepository<WebUser> rpwebuser;


        public BaseController()
        {
            rpproduct = new GenericRepository<Product>();
            rpcategory = new GenericRepository<Category>();
            rpwebuser = new GenericRepository<WebUser>();

            rpcategory.Add
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.UserName = HttpContext.User.Identity.Name;
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }

    }
}