namespace FoodStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateFormat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Menus", "FoodName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Menus", "FoodName", c => c.String());
        }
    }
}
