using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShoeShopMVCAdmin.Models
{
    public class AdminContext:DbContext
    {
        public AdminContext():base("name=AdminCS")
        {
            
        }

        public DbSet<tblBrand> tblBrands { get; set; }
        public DbSet<tblSize> tblSizes { get; set; }
        public DbSet<tblCategory> tblCategories { get; set; }
        public DbSet<tblGender> tblGenders { get; set; }
        public DbSet<tblProduct> tblProducts { get; set; }

        public DbSet<tblUser> tblUsers { get; set; }
    }
}