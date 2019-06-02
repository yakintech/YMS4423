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
    public class ProductManager
    {
        //public static List<Product> GetAllProducts()
        //{
        //    using (BilgeAdamContext db = new BilgeAdamContext())
        //    {
        //        return db.Products.Where(q => q.IsDeleted == false).ToList();
        //    }
        //}

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

        public static List<Product> GetAllProductsWithCount(int count)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                return db.Products.Take(count).ToList();
            }
        }

        //Dışarıdan alınan ID ye göre ürünü dönen metot
        public static Product GetProductbyID(int id)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                return db.Products.FirstOrDefault(x => x.ID == id && x.IsDeleted == false);
            }
        }

        //Dışarıdan aldığu stringe göre ürün adında o kelime geçen ÜRÜNLER
        public static List<Product> GetAllProductsbySearchProductName(string name)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                return db.Products.Where(q => q.ProductName.Contains(name)).ToList();
            }
        }

        //En pahalı ürün
        public static Product GetProductMaxUnitPrice()
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                //test edilecek
                return db.Products.OrderBy(q => q.UnitPrice).Max();


                return db.Products.OrderBy(q => q.UnitPrice).Take(1).FirstOrDefault();
            }
        }

        //ürünün kategorisinin adı dışarıdan gelen string ile başlayan ÜRÜNLER
        public static List<Product> GetAllProductsbyCategoryName(string categoryname)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                //patlayabilir !
                return db.Products.Where(q => q.Category.CategoryName.StartsWith(categoryname)).ToList();
            }
        }

        //dışarıdan alınan isme göre ürün var mı?
        public static bool CheckProductwithProductName(string name)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                bool result = db.Products.Any(q => q.ProductName == name);

                return result;

                //Product product = db.Products.FirstOrDefault(q => q.ProductName == name);

                //if (product != null)
                //    return true;
                //else
                //    return false;
            }
        }

        //update metodu
        public static void UpdateProduct(Product product)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
            }

        }

        //id ye göre HARD silme metodu
        public static void HardDeleteProduct(int id)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                Product product = db.Products.FirstOrDefault(q => q.ID == id);
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }

        //idye göre silme
        public static void DeleteProduct(int id)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                Product product = db.Products.FirstOrDefault(q => q.ID == id);
                product.IsDeleted = true;
                product.DeleteDate = DateTime.Now;

                db.SaveChanges();
                
            }
        }

        //IsDeleted'ı false olan tüm ürünleri getirme
        public static List<Product> IsDeletedFalse(bool isDeleted)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                return db.Products.OrderBy(x => x.IsDeleted == false ).ToList();
            }
        }



    }
}
