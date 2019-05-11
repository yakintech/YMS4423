﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.ORM.Entity
{
    public class Supplier : Base
    {
        [Required]
        public string CompanyName { get; set; }

        public string Description { get; set; }
    }
}
