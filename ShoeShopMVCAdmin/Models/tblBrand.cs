using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoeShopMVCAdmin.Models
{
    public class tblBrand
    {
        [Key]
        public int BrandId { get; set; }

        [DisplayName("Brand Name")]
        [Required(ErrorMessage ="Brand Name Required")]
        public string BrandName { get; set; }

        public ICollection<tblProduct> tblProducts { get; set; }
    }
}