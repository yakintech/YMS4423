using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.ORM.Entity
{
    public class WebUser : Base
    {
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
