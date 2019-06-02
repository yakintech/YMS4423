using BilgeAdam.Business.Manager;
using BilgeAdam.Business.Repository;
using BilgeAdam.Data.ORM.Entity;
using BilgeAdam.UI.Web.Models.VM;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeAdam.UI.Web.Controllers
{
    public class SupplierController : BaseController
    {
        GenericRepository<Supplier> supplierrepo = new GenericRepository<Supplier>();
        public ActionResult Index()
        {
            //int year = DateTime.Now.Year;
            //int month = DateTime.Now.Month;
            //int day = DateTime.Now.Day;


            List<SupplierVM> model = new List<SupplierVM>();

            List<Supplier> suppliers =supplierrepo.GetAll();


            foreach (var item in suppliers)
            {
                //new CultureInfo("en-US")
                SupplierVM svm = new SupplierVM();
                svm.ID = item.ID;
                svm.AddDate = item.AddDate.ToString("dd MMMM yyyy dddd", new CultureInfo("tr-TR"));
               // svm.AddDate = item.AddDate.ToString("dddd, dd MMMM yyyy");
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





        public JsonResult RemoveSupplier(int id)
        {

            supplierrepo.Delete(id);


            return Json("İşlem başarılı",JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAllSuppliers()
        {
            List<Supplier> data = supplierrepo.GetAll();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}