namespace CIS_264_Price_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Details_Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Arts_Crafts_D_O", "Details", c => c.String());
            AddColumn("dbo.Arts_Crafts_P_Q", "Details", c => c.String());
            AddColumn("dbo.Arts_Crafts_R_S", "Details", c => c.String());
            AddColumn("dbo.Arts_Crafts_T_Z", "Details", c => c.String());
            AddColumn("dbo.Halloweens", "Details", c => c.String());
            AddColumn("dbo.July4th", "Details", c => c.String());
            AddColumn("dbo.Sts", "Details", c => c.String());
            AddColumn("dbo.Valentines", "Details", c => c.String());
            AddColumn("dbo.XmasandNewYears", "Details", c => c.String());
            AddColumn("dbo.Misc_A_F", "Details", c => c.String());
            AddColumn("dbo.Misc_G_L", "Details", c => c.String());
            AddColumn("dbo.Misc_M_O", "Details", c => c.String());
            AddColumn("dbo.Misc_P", "Details", c => c.String());
            AddColumn("dbo.Misc_Q_S", "Details", c => c.String());
            AddColumn("dbo.Misc_T_Z", "Details", c => c.String());
            AddColumn("dbo.Products", "Details", c => c.String());
            AddColumn("dbo.Programs", "Details", c => c.String());
            AddColumn("dbo.School_Office_A_B", "Details", c => c.String());
            AddColumn("dbo.School_Office_Q_Z", "Details", c => c.String());
            AddColumn("dbo.School_Office_C_D", "Details", c => c.String());
            AddColumn("dbo.School_Office_E_K", "Details", c => c.String());
            AddColumn("dbo.School_Office_L_N", "Details", c => c.String());
            AddColumn("dbo.School_Office_O_P", "Details", c => c.String());
            AddColumn("dbo.Textiles_W_Z", "Details", c => c.String());
            AddColumn("dbo.Textiles_D_N", "Details", c => c.String());
            AddColumn("dbo.Textiles_P_S", "Details", c => c.String());
            AddColumn("dbo.Textiles_T_V", "Details", c => c.String());
            AddColumn("dbo.Textiles_A_C", "Details", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Textiles_A_C", "Details");
            DropColumn("dbo.Textiles_T_V", "Details");
            DropColumn("dbo.Textiles_P_S", "Details");
            DropColumn("dbo.Textiles_D_N", "Details");
            DropColumn("dbo.Textiles_W_Z", "Details");
            DropColumn("dbo.School_Office_O_P", "Details");
            DropColumn("dbo.School_Office_L_N", "Details");
            DropColumn("dbo.School_Office_E_K", "Details");
            DropColumn("dbo.School_Office_C_D", "Details");
            DropColumn("dbo.School_Office_Q_Z", "Details");
            DropColumn("dbo.School_Office_A_B", "Details");
            DropColumn("dbo.Programs", "Details");
            DropColumn("dbo.Products", "Details");
            DropColumn("dbo.Misc_T_Z", "Details");
            DropColumn("dbo.Misc_Q_S", "Details");
            DropColumn("dbo.Misc_P", "Details");
            DropColumn("dbo.Misc_M_O", "Details");
            DropColumn("dbo.Misc_G_L", "Details");
            DropColumn("dbo.Misc_A_F", "Details");
            DropColumn("dbo.XmasandNewYears", "Details");
            DropColumn("dbo.Valentines", "Details");
            DropColumn("dbo.Sts", "Details");
            DropColumn("dbo.July4th", "Details");
            DropColumn("dbo.Halloweens", "Details");
            DropColumn("dbo.Arts_Crafts_T_Z", "Details");
            DropColumn("dbo.Arts_Crafts_R_S", "Details");
            DropColumn("dbo.Arts_Crafts_P_Q", "Details");
            DropColumn("dbo.Arts_Crafts_D_O", "Details");
        }
    }
}
