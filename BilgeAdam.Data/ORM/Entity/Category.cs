using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.ORM.Entity
{
    public class Category : Base
    {
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
