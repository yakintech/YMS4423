using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.ORM.Entity
{
    public class Base
    {
        public int ID { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public bool IsDeleted { get; set; }

    }
}
