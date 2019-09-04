using PROJE_ASLIACAROZ.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Html;
using System.Web.Security;
using PROJE_ASLIACAROZ.Models.ORM.Context;

namespace PROJE_ASLIACAROZ.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login


        private BlogContext db = new BlogContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index (LoginModel model)
        {
            if (ModelState.IsValid )
            {
                if (db.AdminUsers.Any(x => x.EMail == model.Email && x.Password == model.Password && x.IsDeleted == false))
                {
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    return RedirectToAction("Index", "Home");
                }

                else
                {
                    return View();

                }
              

            }

            else
            {

                return View();
            }

        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index");

        }
    }
}