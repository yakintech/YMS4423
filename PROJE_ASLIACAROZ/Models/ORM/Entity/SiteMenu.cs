using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJE_ASLIACAROZ.Models.ORM.Entity
{
    public class SiteMenu : BaseEntity
    {

        public string MenuName { get; set; }
        public String URL { get; set; }

        
    }
}