using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BilgeAdam.UI.Web.Models.VM
{
    /// <summary>
    /// Listeleme ve ekleme işlemleri için oluşturdupum SupplierVM
    /// </summary>
    public class SupplierVM
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Ad boş geçilemez")]
        public string SirketAd { get; set; }

        public string Aciklama { get; set; }

        public string AddDate { get; set; }
    }
}