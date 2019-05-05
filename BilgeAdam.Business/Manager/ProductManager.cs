using BilgeAdam.Data.ORM.Context;
using BilgeAdam.Data.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Business.Manager
{
    public class ProductManager
    {
        public static List<Product> GetAllProducts()
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                return db.Products.ToList();
            }
        }

        public static void AddProduct(Product product)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                product.AddDate = DateTime.Now;
                product.IsDeleted = false;
                product.UpdateDate = DateTime.Now;

                db.Products.Add(product);

                db.SaveChanges();
            }
        }


        public List<Product> GetAllProductsWithCount(int count)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                return db.Products.Take(count).ToList();
            }
        }
    }
}
