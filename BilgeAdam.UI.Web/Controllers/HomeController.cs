using BilgeAdam.Business.Manager;
using BilgeAdam.Business.Repository;
using BilgeAdam.Data.ORM.Context;
using BilgeAdam.Data.ORM.Entity;
using BilgeAdam.UI.Web.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeAdam.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        GenericRepository<Product> rpproduct = new GenericRepository<Product>();
        public ActionResult Index()
        {
            Product product = new Product();
            product.ProductName = "asdasd";


            rpproduct.Add(product);

            //ürün listesini getir
            rpproduct.GetAll();

            //a harfi ile başlayan ürünler
            rpproduct.GetAll().Where(q => q.ProductName.StartsWith("A")).ToList();

            rpproduct.GetAllWithQueryable(q => q.ProductName.StartsWith("A"));

            //içerisinde a geçen ürünler

            //a ile biten ürünler

            //fiyatı  500 den büyük ürünler
            rpproduct.GetAllWithQueryable(q => q.UnitPrice > 500);

            return View();
        }
    }
}