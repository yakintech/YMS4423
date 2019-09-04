using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROJE_ASLIACAROZ.Areas.Admin.Models.DTO
{
    public class LoginModel
    {

        [Required(ErrorMessage ="Lütfen email adresini doldurunuz")]
        [EmailAddress(ErrorMessage = "Düzgün bir email.adresi giriniz")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Lütfen parola kısmını doldurudunuz")]
        public string Password { get; set; }
    }
}