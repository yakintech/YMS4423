using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BilgeAdam.UI.Web.Models.VM
{
    public class CategoryVM
    {
        [Required(ErrorMessage = "Kategori adı boş geçilemez")]
        [Display(Name = "Kategori Adı")]
        public string KategoriAdi { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

    }
}