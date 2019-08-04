using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROJE_ASLIACAROZ.Models.ORM.Entity
{
    public class WebUser : BaseEntity
    {

        public string Name { get; set; }

        public string Surname { get; set; }


        [Required]
        [StringLength(30)]
        public string EMail { get; set; }

        [Required]
        public string Password { get; set; }
    }
}