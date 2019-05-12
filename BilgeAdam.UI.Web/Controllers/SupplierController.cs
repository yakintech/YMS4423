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

        public ActionResult Index()
        {
            List<SupplierVM> model = new List<SupplierVM>();

            List<Supplier> suppliers = SupplierManager.GetAllSuppliers();


            foreach (var item in suppliers)
            {
                SupplierVM svm = new SupplierVM();
                svm.ID = item.ID;
                svm.AddDate = item.AddDate;
                svm.Aciklama = item.Description;
                svm.SirketAd = item.CompanyName;

                model.Add(svm);

            }


            return View(model);
        }

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


                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }

        public ActionResult DeleteSupplier(int id)
        {
            SupplierManager.DeleteSupplier(id);
            return RedirectToAction("Index");
        }


        public string Merhaba()
        {
            return "Merhaba dünya!";
        }
    }
}