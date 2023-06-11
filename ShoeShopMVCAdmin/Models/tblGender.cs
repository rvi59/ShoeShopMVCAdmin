using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoeShopMVCAdmin.Models
{
    public class tblGender
    {
        [Key]
        public int GenderId { get; set; }

        [DisplayName("Gender Type")]
        [Required(ErrorMessage = "Gender is Required")]
        public string GenderType { get; set; }
        public ICollection<tblProduct> tblProducts { get; set; }
    }
}