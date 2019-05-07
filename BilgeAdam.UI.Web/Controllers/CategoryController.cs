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
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            List<Category> categories = CategoryManager.GetAllCategories();

            return View(categories);
        }

        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(CategoryVM model)
        {
            Category entity = new Category();
            entity.CategoryName = model.KategoriAdi;
            entity.Description = model.Aciklama;

            CategoryManager.AddCategory(entity);
            return View();
        }
    }
}