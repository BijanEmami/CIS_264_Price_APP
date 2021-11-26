namespace CIS_264_Price_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateallclassstringprice : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Arts_Crafts_A_C", "Price", c => c.String());
            AlterColumn("dbo.Arts_Crafts_P_Q", "Price", c => c.String());
            AlterColumn("dbo.Arts_Crafts_R_S", "Price", c => c.String());
            AlterColumn("dbo.Arts_Crafts_T_Z", "Price", c => c.String());
            AlterColumn("dbo.Halloweens", "Price", c => c.String());
            AlterColumn("dbo.July4th", "Price", c => c.String());
            AlterColumn("dbo.Sts", "Price", c => c.String());
            AlterColumn("dbo.Valentines", "Price", c => c.String());
            AlterColumn("dbo.XmasandNewYears", "Price", c => c.String());
            AlterColumn("dbo.Misc_A_F", "Price", c => c.String());
            AlterColumn("dbo.Misc_G_L", "Price", c => c.String());
            AlterColumn("dbo.Misc_M_O", "Price", c => c.String());
            AlterColumn("dbo.Misc_P", "Price", c => c.String());
            AlterColumn("dbo.Misc_Q_S", "Price", c => c.String());
            AlterColumn("dbo.Misc_T_Z", "Price", c => c.String());
            AlterColumn("dbo.Products", "Price", c => c.String());
            AlterColumn("dbo.Programs", "Price", c => c.String());
            AlterColumn("dbo.School_Office_A_B", "Price", c => c.String());
            AlterColumn("dbo.School_Office_Q_Z", "Price", c => c.String());
            AlterColumn("dbo.School_Office_C_D", "Price", c => c.String());
            AlterColumn("dbo.School_Office_E_K", "Price", c => c.String());
            AlterColumn("dbo.School_Office_L_N", "Price", c => c.String());
            AlterColumn("dbo.School_Office_O_P", "Price", c => c.String());
            AlterColumn("dbo.Textiles_W_Z", "Price", c => c.String());
            AlterColumn("dbo.Textiles_D_N", "Price", c => c.String());
            AlterColumn("dbo.Textiles_P_S", "Price", c => c.String());
            AlterColumn("dbo.Textiles_T_V", "Price", c => c.String());
            AlterColumn("dbo.Textiles_A_C", "Price", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Textiles_A_C", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Textiles_T_V", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Textiles_P_S", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Textiles_D_N", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Textiles_W_Z", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.School_Office_O_P", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.School_Office_L_N", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.School_Office_E_K", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.School_Office_C_D", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.School_Office_Q_Z", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.School_Office_A_B", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Programs", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Misc_T_Z", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Misc_Q_S", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Misc_P", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Misc_M_O", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Misc_G_L", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Misc_A_F", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.XmasandNewYears", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Valentines", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Sts", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.July4th", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Halloweens", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Arts_Crafts_T_Z", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Arts_Crafts_R_S", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Arts_Crafts_P_Q", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Arts_Crafts_A_C", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
