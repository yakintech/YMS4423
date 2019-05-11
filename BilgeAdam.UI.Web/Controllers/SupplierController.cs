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
    public class SupplierController : Controller
    {
        public ActionResult AddSupplier()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSupplier(SupplierVM model)
        {
            if (ModelState.IsValid)
            {
                Supplier entity = new Supplier();
                entity.CompanyName = model.SirketAd;
                entity.Description = model.Aciklama;

                SupplierManager.AddSupplier(entity);


                return View();
            }
            else
            {
                return View();
            }

        }
    }
}