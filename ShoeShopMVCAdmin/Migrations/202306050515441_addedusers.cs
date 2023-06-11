namespace ShoeShopMVCAdmin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedusers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        UserEmail = c.String(),
                        Name = c.String(),
                        Usertype = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblUsers");
        }
    }
}
