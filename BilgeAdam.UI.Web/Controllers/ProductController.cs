﻿using BilgeAdam.Business.Manager;
using BilgeAdam.Data.ORM.Entity;
using BilgeAdam.UI.Web.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeAdam.UI.Web.Controllers
{
    public class ProductController : Controller
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
                pmodel.KategoriAd = item.Category?.CategoryName;
                pmodel.UrunAdi = item.ProductName;


                model2.Add(pmodel);
            }
            #endregion

            List<ProductVM> model = ProductManager.GetAllProducts().Select(q => new ProductVM()
            {
                UrunAdi = q.ProductName,
                Fiyat = q.UnitPrice,
                EklenmeTarih = q.AddDate,
                KategoriAd = q.Category?.CategoryName
            }).ToList();

            return View(model);
        }
    }
}