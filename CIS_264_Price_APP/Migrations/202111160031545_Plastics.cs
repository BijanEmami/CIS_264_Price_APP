namespace CIS_264_Price_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Plastics : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plastics",
                c => new
                    {
                        Holidays_ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Holidays_ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Products_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Plastics_Holidays_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Products_ID)
                .ForeignKey("dbo.Plastics", t => t.Plastics_Holidays_ID)
                .Index(t => t.Plastics_Holidays_ID);
            
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        Programs_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Plastics_Holidays_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Programs_ID)
                .ForeignKey("dbo.Plastics", t => t.Plastics_Holidays_ID)
                .Index(t => t.Plastics_Holidays_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Programs", "Plastics_Holidays_ID", "dbo.Plastics");
            DropForeignKey("dbo.Products", "Plastics_Holidays_ID", "dbo.Plastics");
            DropIndex("dbo.Programs", new[] { "Plastics_Holidays_ID" });
            DropIndex("dbo.Products", new[] { "Plastics_Holidays_ID" });
            DropTable("dbo.Programs");
            DropTable("dbo.Products");
            DropTable("dbo.Plastics");
        }
    }
}
