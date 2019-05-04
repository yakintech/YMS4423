using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BilgeAdam.UI.Web.Models.VM
{
    public class AdminUserVM
    {
        [Required(ErrorMessage ="EMail alanı boş geçilemez")]
        [EmailAddress(ErrorMessage ="EMail format hatası")]
        [Display(Name = "E-Posta")]
        public string EMail { get; set; }

        [Required(ErrorMessage ="Parola alanı boş geçilemez")]
        [Display(Name ="Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Parola tekrar alanı boş geçilemez")]
        [Compare("Password",ErrorMessage = "Parolalar uyuşmuyor")]
        [Display(Name = "Şifre Tekrar")]
        public string ConfrimPassword { get; set; }
    }
}