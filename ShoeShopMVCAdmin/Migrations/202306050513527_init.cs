namespace ShoeShopMVCAdmin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblBrands",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                    })
                .PrimaryKey(t => t.BrandId);
            
            CreateTable(
                "dbo.tblProducts",
                c => new
                    {
                        ProdId = c.Int(nullable: false, identity: true),
                        ProdName = c.String(),
                        ProdPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProdSeelingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProdImage = c.String(),
                        ProdDesc = c.String(),
                        ProdShortName = c.String(),
                        ProdQuantity = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        GenderId = c.Int(nullable: false),
                        SizeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdId)
                .ForeignKey("dbo.tblBrands", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.tblCategories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.tblGenders", t => t.GenderId, cascadeDelete: true)
                .ForeignKey("dbo.tblSizes", t => t.SizeId, cascadeDelete: true)
                .Index(t => t.BrandId)
                .Index(t => t.CategoryId)
                .Index(t => t.GenderId)
                .Index(t => t.SizeId);
            
            CreateTable(
                "dbo.tblCategories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.tblGenders",
                c => new
                    {
                        GenderId = c.Int(nullable: false, identity: true),
                        GenderType = c.String(),
                    })
                .PrimaryKey(t => t.GenderId);
            
            CreateTable(
                "dbo.tblSizes",
                c => new
                    {
                        SizeId = c.Int(nullable: false, identity: true),
                        SizeNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SizeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblProducts", "SizeId", "dbo.tblSizes");
            DropForeignKey("dbo.tblProducts", "GenderId", "dbo.tblGenders");
            DropForeignKey("dbo.tblProducts", "CategoryId", "dbo.tblCategories");
            DropForeignKey("dbo.tblProducts", "BrandId", "dbo.tblBrands");
            DropIndex("dbo.tblProducts", new[] { "SizeId" });
            DropIndex("dbo.tblProducts", new[] { "GenderId" });
            DropIndex("dbo.tblProducts", new[] { "CategoryId" });
            DropIndex("dbo.tblProducts", new[] { "BrandId" });
            DropTable("dbo.tblSizes");
            DropTable("dbo.tblGenders");
            DropTable("dbo.tblCategories");
            DropTable("dbo.tblProducts");
            DropTable("dbo.tblBrands");
        }
    }
}
