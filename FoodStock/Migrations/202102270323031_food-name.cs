namespace FoodStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foodname : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "FoodItem");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "FoodItem", c => c.String());
        }
    }
}
