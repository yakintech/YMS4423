using BilgeAdam.Data.ORM.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.ORM.Entity
{
    public class AdminUser : Base,IUserLog
    {
        [Required]
        [StringLength(100)]
        public string EMail { get; set; }
        public string Password { get; set; }
        public int InsertedUserID { get; set; }
        public int UpdatedUserID { get; set; }
        public int? DeletedUserID { get; set; }
    }
}
