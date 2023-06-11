using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoeShopMVCAdmin.Models
{
    public class tblUser
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserEmail { get; set; }
        public string Name { get; set; }
        public string Usertype { get; set; }
    }
}