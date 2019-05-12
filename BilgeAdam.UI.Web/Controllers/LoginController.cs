using BilgeAdam.UI.Web.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BilgeAdam.UI.Web.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginVM model)
        {
            //db den kullanıcı email ve şifreyi kontrol etmem gerek!!!!!
            if (model.EMail == "cagatay@mail.com" && model.Password == "123")
            {

                FormsAuthentication.SetAuthCookie(model.EMail, true);

                return RedirectToAction("Index", "Supplier");
            }
            else
            {
                return View();
            }
            
        }


        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index");
        }
    }
}