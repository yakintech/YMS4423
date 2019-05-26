using BilgeAdam.Business.Manager;
using BilgeAdam.Business.Repository;
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


            GenericRepository<Product> gproduct = new GenericRepository<Product>();


            return View();
        }
    }
}