using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeAdam.UI.Web.Models.VM
{
    public class UrunVM
    {
        [Required(ErrorMessage ="Ürün adı boş geçilemez")]
        public string Ad { get; set; }

        [Required(ErrorMessage ="Fiyat alanı boş geçilemez")]
        public decimal Fiyat { get; set; }

        public int CategoryID { get; set; }

        public List<SelectListItem> drpKategoriler { get; set; }




    }
}