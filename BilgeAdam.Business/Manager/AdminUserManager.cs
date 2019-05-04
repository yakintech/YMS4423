using BilgeAdam.Data.ORM.Context;
using BilgeAdam.Data.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Business.Manager
{
    public class AdminUserManager
    {
        //List<AdminUser> admindb.AdminUsers.ToList();
        //AdminUser ları getiren metot

        public static List<AdminUser> GetAllAdminUsers()
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                return db.AdminUsers.ToList();
            }
        }

        public static void AddAdminUser(AdminUser adminuser)
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                adminuser.InsertedUserID = 1;
                adminuser.UpdatedUserID = 1;
                adminuser.AddDate = DateTime.Now;
                adminuser.IsDeleted = false;
                adminuser.UpdateDate = DateTime.Now;

                db.AdminUsers.Add(adminuser);

                db.SaveChanges();

            }
        }

    }
}
