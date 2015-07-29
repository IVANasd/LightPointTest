namespace LightPointTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShopWorkTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shops", "WorkTimeString", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shops", "WorkTimeString");
        }
    }
}
