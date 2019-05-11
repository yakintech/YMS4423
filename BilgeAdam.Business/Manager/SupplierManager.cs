using BilgeAdam.Data.ORM.Context;
using BilgeAdam.Data.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Business.Manager
{
    public class SupplierManager
    {
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
    }
}
