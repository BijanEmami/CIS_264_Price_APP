namespace CIS_264_Price_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HolidayClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Halloweens",
                c => new
                    {
                        Halloween_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Holidays_Holidays_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Halloween_ID)
                .ForeignKey("dbo.Holidays", t => t.Holidays_Holidays_ID)
                .Index(t => t.Holidays_Holidays_ID);
            
            CreateTable(
                "dbo.Holidays",
                c => new
                    {
                        Holidays_ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Holidays_ID);
            
            CreateTable(
                "dbo.July4th",
                c => new
                    {
                        July4th_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Holidays_Holidays_ID = c.Int(),
                    })
                .PrimaryKey(t => t.July4th_ID)
                .ForeignKey("dbo.Holidays", t => t.Holidays_Holidays_ID)
                .Index(t => t.Holidays_Holidays_ID);
            
            CreateTable(
                "dbo.Sts",
                c => new
                    {
                        St_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Holidays_Holidays_ID = c.Int(),
                    })
                .PrimaryKey(t => t.St_ID)
                .ForeignKey("dbo.Holidays", t => t.Holidays_Holidays_ID)
                .Index(t => t.Holidays_Holidays_ID);
            
            CreateTable(
                "dbo.Valentines",
                c => new
                    {
                        Valentines_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Holidays_Holidays_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Valentines_ID)
                .ForeignKey("dbo.Holidays", t => t.Holidays_Holidays_ID)
                .Index(t => t.Holidays_Holidays_ID);
            
            CreateTable(
                "dbo.XmasandNewYears",
                c => new
                    {
                        XmasandNewYear_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Holidays_Holidays_ID = c.Int(),
                    })
                .PrimaryKey(t => t.XmasandNewYear_ID)
                .ForeignKey("dbo.Holidays", t => t.Holidays_Holidays_ID)
                .Index(t => t.Holidays_Holidays_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.XmasandNewYears", "Holidays_Holidays_ID", "dbo.Holidays");
            DropForeignKey("dbo.Valentines", "Holidays_Holidays_ID", "dbo.Holidays");
            DropForeignKey("dbo.Sts", "Holidays_Holidays_ID", "dbo.Holidays");
            DropForeignKey("dbo.July4th", "Holidays_Holidays_ID", "dbo.Holidays");
            DropForeignKey("dbo.Halloweens", "Holidays_Holidays_ID", "dbo.Holidays");
            DropIndex("dbo.XmasandNewYears", new[] { "Holidays_Holidays_ID" });
            DropIndex("dbo.Valentines", new[] { "Holidays_Holidays_ID" });
            DropIndex("dbo.Sts", new[] { "Holidays_Holidays_ID" });
            DropIndex("dbo.July4th", new[] { "Holidays_Holidays_ID" });
            DropIndex("dbo.Halloweens", new[] { "Holidays_Holidays_ID" });
            DropTable("dbo.XmasandNewYears");
            DropTable("dbo.Valentines");
            DropTable("dbo.Sts");
            DropTable("dbo.July4th");
            DropTable("dbo.Holidays");
            DropTable("dbo.Halloweens");
        }
    }
}
