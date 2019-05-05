using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.ORM.Entity
{
    public class Product : Base
    {
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
    }
}
