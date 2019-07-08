using BilgeAdam.Data.ORM.Context;
using BilgeAdam.Data.ORM.Entity;
using System;
using System.Collections.Generic;
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

                return db.Categories.Where(q => q.IsDeleted == false).ToList();
            }
        }

        public static void DeleteCategory(int id)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                Category category = db.Categories.FirstOrDefault(q => q.ID == id);
                category.IsDeleted = true;
                category.DeleteDate = DateTime.Now;

                db.SaveChanges();

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
}
