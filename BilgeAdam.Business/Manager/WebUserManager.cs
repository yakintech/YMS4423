using BilgeAdam.Data.ORM.Context;
using BilgeAdam.Data.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Business.Manager
{
    public class WebUserManager
    {
        public static List<WebUser> GetAllWebUsers()
        {
            using (BilgeAdamContext db = new BilgeAdamContext())
            {
                return db.WebUsers.Where(q => q.IsDeleted == false).ToList();
            }
        }
    }
}
