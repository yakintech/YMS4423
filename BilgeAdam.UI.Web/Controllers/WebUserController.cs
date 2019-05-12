using BilgeAdam.Business.Manager;
using BilgeAdam.Data.ORM.Entity;
using BilgeAdam.UI.Web.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeAdam.UI.Web.Controllers
{
    public class WebUserController : BaseController
    {
        public ActionResult Index()
        {
            List<WebUser> webusers = WebUserManager.GetAllWebUsers();

            List<WebUserVM> model = new List<WebUserVM>();

            foreach (var item in webusers)
            {
                WebUserVM webuservm = new WebUserVM();
                webuservm.ID = item.ID;
                webuservm.AdSoyad = item.Name + " " + item.SurName;
                webuservm.Yas = DateTime.Now.Year - item.BirthDate.Year;

                model.Add(webuservm);
            }




            return View(model);
        }
    }
}