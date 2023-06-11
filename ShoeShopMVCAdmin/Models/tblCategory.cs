using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoeShopMVCAdmin.Models
{
    public class tblCategory
    {
        [Key]
        public int CategoryId { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category Name Required")]
        public string CategoryName { get; set; }
        public ICollection<tblProduct> tblProducts { get; set; }
    }
}