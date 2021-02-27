namespace FoodStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revertback : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "FoodID", c => c.Int());
            DropColumn("dbo.Orders", "FoodName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "FoodName", c => c.String());
            DropColumn("dbo.Orders", "FoodID");
        }
    }
}
