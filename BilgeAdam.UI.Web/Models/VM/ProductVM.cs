using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilgeAdam.UI.Web.Models.VM
{
    public class ProductVM
    {
        public int ID { get; set; }
        public string UrunAdi { get; set; }

        public decimal Fiyat { get; set; }

        public DateTime EklenmeTarih { get; set; }

        public string KategoriAd { get; set; }

        public string FiyatTL { get; set; }

        public string ImgPath { get; set; }

    }
}