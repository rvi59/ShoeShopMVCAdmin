using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoeShopMVCAdmin.Models
{
    public class tblSize
    {
        [Key]
        public int SizeId { get; set; }

        [DisplayName("Size Number")]
        [Required(ErrorMessage = "Size Number is Required")]
        public int SizeNumber { get; set; }
        public ICollection<tblProduct> tblProducts { get; set; }
    }
}