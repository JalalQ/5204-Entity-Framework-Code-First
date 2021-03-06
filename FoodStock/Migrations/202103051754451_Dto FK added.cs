namespace FoodStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DtoFKadded : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "FoodID");
            RenameColumn(table: "dbo.Orders", name: "Menu_ID", newName: "FoodID");
            RenameIndex(table: "dbo.Orders", name: "IX_Menu_ID", newName: "IX_FoodID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Orders", name: "IX_FoodID", newName: "IX_Menu_ID");
            RenameColumn(table: "dbo.Orders", name: "FoodID", newName: "Menu_ID");
            AddColumn("dbo.Orders", "FoodID", c => c.Int());
        }
    }
}
