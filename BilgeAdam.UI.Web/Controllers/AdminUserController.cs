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
    public class AdminUserController : Controller
    {
        public ActionResult Index()
        {
            List<AdminUser> adminusers = AdminUserManager.GetAllAdminUsers();

            return View(adminusers);
        }

        public ActionResult AddAdminUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdminUser(AdminUserVM model)
        {
            AdminUser entity = new AdminUser();
            entity.EMail = model.EMail.ToLower();
            entity.Password = model.Password;

            AdminUserManager.AddAdminUser(entity);
            return View();
        }

       


    }
}