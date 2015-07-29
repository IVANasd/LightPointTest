namespace LightPointTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShopProducts",
                c => new
                    {
                        Shop_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Shop_Id, t.Product_Id })
                .ForeignKey("dbo.Shops", t => t.Shop_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Shop_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShopProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ShopProducts", "Shop_Id", "dbo.Shops");
            DropIndex("dbo.ShopProducts", new[] { "Product_Id" });
            DropIndex("dbo.ShopProducts", new[] { "Shop_Id" });
            DropTable("dbo.ShopProducts");
            DropTable("dbo.Shops");
            DropTable("dbo.Products");
        }
    }
}
