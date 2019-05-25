using BilgeAdam.Business.Manager;
using BilgeAdam.Data.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeAdam.UI.Web.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            GenericBilgeAdam<Category> genericbilgeadam = new GenericBilgeAdam<Category>();


            return View();
        }
    }
}