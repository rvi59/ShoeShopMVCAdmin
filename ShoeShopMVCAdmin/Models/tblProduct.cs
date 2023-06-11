using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace ShoeShopMVCAdmin.Models
{
    public class tblProduct
    {
        [Key]
        public int ProdId { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product Name is Required")]
        public string ProdName { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Price is Required")]
        public decimal ProdPrice { get; set; }

        [DisplayName("Selling Price")]
        [Required(ErrorMessage = "Selling Price is Required")]
        public decimal ProdSeelingPrice { get; set; }

        public string ProdImage { get; set; }

        [NotMapped]
        public HttpPostedFileBase myImg { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "Description is Required")]
        public string ProdDesc { get; set; }

        [DisplayName("Short Name")]
        [Required(ErrorMessage = "Short Name is Required")]
        public string ProdShortName { get; set; }

        [DisplayName("Quantity")]
        [Required(ErrorMessage = "Quantity is Required")]
        public int ProdQuantity { get; set; }

        
        [Required(ErrorMessage = "Brand is Required")]
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public tblBrand tblBrand { get; set; }

       
        [Required(ErrorMessage = "Category is Required")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public tblCategory tblCategory { get; set; }

        
        [Required(ErrorMessage = "Gender is Required")]
        public int GenderId { get; set; }
        [ForeignKey("GenderId")]
        public tblGender tblGender { get; set; }

       
        [Required(ErrorMessage = "Size is Required")]
        public int SizeId { get; set; }
        [ForeignKey("SizeId")]
        public tblSize tblSize { get; set; }
    }
}