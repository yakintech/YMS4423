using BilgeAdam.Business.Manager;
using BilgeAdam.Data.ORM.Entity;
using BilgeAdam.UI.Web.Models.VM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeAdam.UI.Web.Controllers
{
    public class ProductController : BaseController
    {
        //Ürünün adı,  fiyatı, eklenme tarihi ve kategorisinin adı
        public ActionResult Index()
        {
            #region uzun
            List<Product> products = ProductManager.GetAllProducts();

            List<ProductVM> model2 = new List<ProductVM>();

            foreach (var item in products)
            {
                ProductVM pmodel = new ProductVM();
                pmodel.EklenmeTarih = item.AddDate;
                pmodel.Fiyat = item.UnitPrice;
                pmodel.FiyatTL = item.UnitPrice.ToString() + "TL";
                pmodel.KategoriAd = "elektronik";
                pmodel.UrunAdi = item.ProductName;


                model2.Add(pmodel);
            }
            #endregion

            List<ProductVM> model = ProductManager.GetAllProducts().Select(q => new ProductVM()
            {
                ID = q.ID,
                UrunAdi = q.ProductName,
                Fiyat = q.UnitPrice,
                EklenmeTarih = q.AddDate,
                KategoriAd = "elektronik",
                ImgPath = q.ImgPath
        }).ToList();

            return View(model);
        }

        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View(GetUrunVM());
        }

        [HttpPost]
        public ActionResult UrunEkle(UrunVM model,HttpPostedFileBase productfile)
        {
            Product product = new Product();
            product.ProductName = model.Ad;
            product.UnitPrice = model.Fiyat;
            product.CategoryID = model.CategoryID;
         

            if (productfile != null)
            {
                var x = Guid.NewGuid().ToString();
                var filename =x +  productfile.FileName;

                product.ImgPath = filename;

                string dosyaYolu = Path.GetFileName(filename);
                string yuklemeYeri = Path.Combine(Server.MapPath("~/Content/img/uploadFiles"), dosyaYolu);
                productfile.SaveAs(yuklemeYeri);
            }

            ProductManager.AddProduct(product);

            return View(GetUrunVM());

        }

        private UrunVM GetUrunVM()
        {
            List<Category> categories = CategoryManager.GetAllCategories();

            List<SelectListItem> items = new List<SelectListItem>();

            foreach (var item in categories)
            {
                SelectListItem selectitem = new SelectListItem();
                selectitem.Text = item.CategoryName;
                selectitem.Value = item.ID.ToString();


                items.Add(selectitem);
            }


            UrunVM model = new UrunVM();
            model.drpKategoriler = items;

            return model;
        }

        public JsonResult DeleteProduct(int id)
        {
            ProductManager.DeleteProduct(id);
            return Json("");
        }

    }
}