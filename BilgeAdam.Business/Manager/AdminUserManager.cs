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

    }
}
