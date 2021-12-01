namespace CIS_264_Price_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idk : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Arts_Crafts_A_C", "isArchived");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Arts_Crafts_A_C", "isArchived", c => c.Boolean(nullable: false));
        }
    }
}
