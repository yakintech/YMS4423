using BilgeAdam.Data.ORM.Context;
using BilgeAdam.Data.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Business.Manager
{
    public class CategoryManager
    {
        public static List<Category> GetAllCategories()
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                return db.Categories.ToList();
            }
        }

        public static void AddCategory(Category category)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                category.AddDate = DateTime.Now;
                category.IsDeleted = false;
                category.UpdateDate = DateTime.Now;

                db.Categories.Add(category);

                db.SaveChanges();
            }
        }

        public static List<Category> GetAllActiveCategories()
        {
            var data = GetAllCategories().Where(x => x.IsDeleted == false).ToList();

            return data;
        }

        public static void UpdateCategory(Category category)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void DeleteCategory(int id)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                Category deleteddata = db.Categories.FirstOrDefault(x => x.ID == id);
                deleteddata.IsDeleted = true;
                deleteddata.DeleteDate = DateTime.Now;

                db.SaveChanges();
            }
        }

        public static List<Category> SearchMethod(string data)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                return db.Categories.Where(x => x.CategoryName.Contains(data)).ToList();
            }
        }

    }
}
