namespace FoodStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringFoodName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "FoodName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "FoodName", c => c.Int(nullable: false));
        }
    }
}
