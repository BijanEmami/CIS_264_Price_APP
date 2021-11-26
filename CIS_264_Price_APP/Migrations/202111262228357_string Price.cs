namespace CIS_264_Price_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringPrice : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Arts_Crafts_D_O", "Price", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Arts_Crafts_D_O", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
