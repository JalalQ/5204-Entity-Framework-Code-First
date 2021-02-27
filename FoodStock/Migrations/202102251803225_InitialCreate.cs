namespace FoodStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FoodName = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderOn = c.DateTime(nullable: false),
                        OrderedBy = c.String(),
                        FoodID = c.Int(),
                        Menu_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Menus", t => t.Menu_ID)
                .Index(t => t.Menu_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Menu_ID", "dbo.Menus");
            DropIndex("dbo.Orders", new[] { "Menu_ID" });
            DropTable("dbo.Orders");
            DropTable("dbo.Menus");
        }
    }
}
