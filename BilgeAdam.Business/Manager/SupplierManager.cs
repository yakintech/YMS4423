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
    public class SupplierManager
    {

        public static List<Supplier> GetAllSuppliers()
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                return db.Suppliers.Where(q => q.IsDeleted == false).ToList();
            }
        }

        public static void AddSupplier(Supplier supplier)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                supplier.AddDate = DateTime.Now;
                supplier.UpdateDate = DateTime.Now;
                supplier.IsDeleted = false;

                db.Suppliers.Add(supplier);
                db.SaveChanges();
            }
        }

        public static void DeleteSupplier(int id)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                Supplier supplier = db.Suppliers.FirstOrDefault(q => q.ID == id);
                if (supplier != null)
                {
                    supplier.IsDeleted = true;
                    db.SaveChanges();
                }

            }
        }

        public static void UpdateSupplier(Supplier supplier)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                db.Entry(supplier).State = EntityState.Modified;
                db.SaveChanges();
            }

        }
    }
}
