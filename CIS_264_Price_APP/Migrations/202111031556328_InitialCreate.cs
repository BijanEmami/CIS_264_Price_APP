namespace CIS_264_Price_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArtsAndCrafts",
                c => new
                    {
                        ArtsAndCraftsID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ArtsAndCraftsID);
            
            CreateTable(
                "dbo.Arts_Crafts_A_C",
                c => new
                    {
                        Arts_Crafts_A_C_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArtsAndCrafts_ArtsAndCraftsID = c.Int(),
                    })
                .PrimaryKey(t => t.Arts_Crafts_A_C_ID)
                .ForeignKey("dbo.ArtsAndCrafts", t => t.ArtsAndCrafts_ArtsAndCraftsID)
                .Index(t => t.ArtsAndCrafts_ArtsAndCraftsID);
            
            CreateTable(
                "dbo.Arts_Crafts_D_O",
                c => new
                    {
                        Arts_Crafts_D_O_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArtsAndCrafts_ArtsAndCraftsID = c.Int(),
                    })
                .PrimaryKey(t => t.Arts_Crafts_D_O_ID)
                .ForeignKey("dbo.ArtsAndCrafts", t => t.ArtsAndCrafts_ArtsAndCraftsID)
                .Index(t => t.ArtsAndCrafts_ArtsAndCraftsID);
            
            CreateTable(
                "dbo.Arts_Crafts_P_Q",
                c => new
                    {
                        Arts_Crafts_P_Q_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArtsAndCrafts_ArtsAndCraftsID = c.Int(),
                    })
                .PrimaryKey(t => t.Arts_Crafts_P_Q_ID)
                .ForeignKey("dbo.ArtsAndCrafts", t => t.ArtsAndCrafts_ArtsAndCraftsID)
                .Index(t => t.ArtsAndCrafts_ArtsAndCraftsID);
            
            CreateTable(
                "dbo.Arts_Crafts_R_S",
                c => new
                    {
                        Arts_Crafts_R_S_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArtsAndCrafts_ArtsAndCraftsID = c.Int(),
                    })
                .PrimaryKey(t => t.Arts_Crafts_R_S_ID)
                .ForeignKey("dbo.ArtsAndCrafts", t => t.ArtsAndCrafts_ArtsAndCraftsID)
                .Index(t => t.ArtsAndCrafts_ArtsAndCraftsID);
            
            CreateTable(
                "dbo.Arts_Crafts_T_Z",
                c => new
                    {
                        Arts_Crafts_T_Z_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArtsAndCrafts_ArtsAndCraftsID = c.Int(),
                    })
                .PrimaryKey(t => t.Arts_Crafts_T_Z_ID)
                .ForeignKey("dbo.ArtsAndCrafts", t => t.ArtsAndCrafts_ArtsAndCraftsID)
                .Index(t => t.ArtsAndCrafts_ArtsAndCraftsID);
            
            CreateTable(
                "dbo.Miscellaneous",
                c => new
                    {
                        MiscID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.MiscID);
            
            CreateTable(
                "dbo.Misc_A_F",
                c => new
                    {
                        Misc_A_F_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Miscellaneous_MiscID = c.Int(),
                    })
                .PrimaryKey(t => t.Misc_A_F_ID)
                .ForeignKey("dbo.Miscellaneous", t => t.Miscellaneous_MiscID)
                .Index(t => t.Miscellaneous_MiscID);
            
            CreateTable(
                "dbo.Misc_G_L",
                c => new
                    {
                        Misc_G_L_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Miscellaneous_MiscID = c.Int(),
                    })
                .PrimaryKey(t => t.Misc_G_L_ID)
                .ForeignKey("dbo.Miscellaneous", t => t.Miscellaneous_MiscID)
                .Index(t => t.Miscellaneous_MiscID);
            
            CreateTable(
                "dbo.Misc_M_O",
                c => new
                    {
                        Misc_M_O_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Miscellaneous_MiscID = c.Int(),
                    })
                .PrimaryKey(t => t.Misc_M_O_ID)
                .ForeignKey("dbo.Miscellaneous", t => t.Miscellaneous_MiscID)
                .Index(t => t.Miscellaneous_MiscID);
            
            CreateTable(
                "dbo.Misc_P",
                c => new
                    {
                        Misc_P_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Miscellaneous_MiscID = c.Int(),
                    })
                .PrimaryKey(t => t.Misc_P_ID)
                .ForeignKey("dbo.Miscellaneous", t => t.Miscellaneous_MiscID)
                .Index(t => t.Miscellaneous_MiscID);
            
            CreateTable(
                "dbo.Misc_Q_S",
                c => new
                    {
                        Misc_Q_S_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Miscellaneous_MiscID = c.Int(),
                    })
                .PrimaryKey(t => t.Misc_Q_S_ID)
                .ForeignKey("dbo.Miscellaneous", t => t.Miscellaneous_MiscID)
                .Index(t => t.Miscellaneous_MiscID);
            
            CreateTable(
                "dbo.Misc_T_Z",
                c => new
                    {
                        Misc_T_Z_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Miscellaneous_MiscID = c.Int(),
                    })
                .PrimaryKey(t => t.Misc_T_Z_ID)
                .ForeignKey("dbo.Miscellaneous", t => t.Miscellaneous_MiscID)
                .Index(t => t.Miscellaneous_MiscID);
            
            CreateTable(
                "dbo.SchoolAndOffices",
                c => new
                    {
                        SchoolAndOfficeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SchoolAndOfficeID);
            
            CreateTable(
                "dbo.School_Office_Q_Z",
                c => new
                    {
                        School_Office_Q_Z_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SchoolAndOffice_SchoolAndOfficeID = c.Int(),
                    })
                .PrimaryKey(t => t.School_Office_Q_Z_ID)
                .ForeignKey("dbo.SchoolAndOffices", t => t.SchoolAndOffice_SchoolAndOfficeID)
                .Index(t => t.SchoolAndOffice_SchoolAndOfficeID);
            
            CreateTable(
                "dbo.School_Office_C_D",
                c => new
                    {
                        School_Office_C_D_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SchoolAndOffice_SchoolAndOfficeID = c.Int(),
                    })
                .PrimaryKey(t => t.School_Office_C_D_ID)
                .ForeignKey("dbo.SchoolAndOffices", t => t.SchoolAndOffice_SchoolAndOfficeID)
                .Index(t => t.SchoolAndOffice_SchoolAndOfficeID);
            
            CreateTable(
                "dbo.School_Office_E_K",
                c => new
                    {
                        School_Office_E_K_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SchoolAndOffice_SchoolAndOfficeID = c.Int(),
                    })
                .PrimaryKey(t => t.School_Office_E_K_ID)
                .ForeignKey("dbo.SchoolAndOffices", t => t.SchoolAndOffice_SchoolAndOfficeID)
                .Index(t => t.SchoolAndOffice_SchoolAndOfficeID);
            
            CreateTable(
                "dbo.School_Office_L_N",
                c => new
                    {
                        School_Office_L_N_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SchoolAndOffice_SchoolAndOfficeID = c.Int(),
                    })
                .PrimaryKey(t => t.School_Office_L_N_ID)
                .ForeignKey("dbo.SchoolAndOffices", t => t.SchoolAndOffice_SchoolAndOfficeID)
                .Index(t => t.SchoolAndOffice_SchoolAndOfficeID);
            
            CreateTable(
                "dbo.School_Office_O_P",
                c => new
                    {
                        School_Office_O_P_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SchoolAndOffice_SchoolAndOfficeID = c.Int(),
                    })
                .PrimaryKey(t => t.School_Office_O_P_ID)
                .ForeignKey("dbo.SchoolAndOffices", t => t.SchoolAndOffice_SchoolAndOfficeID)
                .Index(t => t.SchoolAndOffice_SchoolAndOfficeID);
            
            CreateTable(
                "dbo.School_Office_A_B",
                c => new
                    {
                        School_Office_A_B_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SchoolAndOffice_SchoolAndOfficeID = c.Int(),
                    })
                .PrimaryKey(t => t.School_Office_A_B_ID)
                .ForeignKey("dbo.SchoolAndOffices", t => t.SchoolAndOffice_SchoolAndOfficeID)
                .Index(t => t.SchoolAndOffice_SchoolAndOfficeID);
            
            CreateTable(
                "dbo.Textiles",
                c => new
                    {
                        TextilesID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TextilesID);
            
            CreateTable(
                "dbo.Textiles_W_Z",
                c => new
                    {
                        Textiles_W_Z_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Textiles_TextilesID = c.Int(),
                    })
                .PrimaryKey(t => t.Textiles_W_Z_ID)
                .ForeignKey("dbo.Textiles", t => t.Textiles_TextilesID)
                .Index(t => t.Textiles_TextilesID);
            
            CreateTable(
                "dbo.Textiles_D_N",
                c => new
                    {
                        Textiles_D_N_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Textiles_TextilesID = c.Int(),
                    })
                .PrimaryKey(t => t.Textiles_D_N_ID)
                .ForeignKey("dbo.Textiles", t => t.Textiles_TextilesID)
                .Index(t => t.Textiles_TextilesID);
            
            CreateTable(
                "dbo.Textiles_P_S",
                c => new
                    {
                        Textiles_P_S_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Textiles_TextilesID = c.Int(),
                    })
                .PrimaryKey(t => t.Textiles_P_S_ID)
                .ForeignKey("dbo.Textiles", t => t.Textiles_TextilesID)
                .Index(t => t.Textiles_TextilesID);
            
            CreateTable(
                "dbo.Textiles_T_V",
                c => new
                    {
                        Textiles_T_V_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Textiles_TextilesID = c.Int(),
                    })
                .PrimaryKey(t => t.Textiles_T_V_ID)
                .ForeignKey("dbo.Textiles", t => t.Textiles_TextilesID)
                .Index(t => t.Textiles_TextilesID);
            
            CreateTable(
                "dbo.Textiles_A_C",
                c => new
                    {
                        Textiles_A_C_ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Textiles_TextilesID = c.Int(),
                    })
                .PrimaryKey(t => t.Textiles_A_C_ID)
                .ForeignKey("dbo.Textiles", t => t.Textiles_TextilesID)
                .Index(t => t.Textiles_TextilesID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Textiles_A_C", "Textiles_TextilesID", "dbo.Textiles");
            DropForeignKey("dbo.Textiles_T_V", "Textiles_TextilesID", "dbo.Textiles");
            DropForeignKey("dbo.Textiles_P_S", "Textiles_TextilesID", "dbo.Textiles");
            DropForeignKey("dbo.Textiles_D_N", "Textiles_TextilesID", "dbo.Textiles");
            DropForeignKey("dbo.Textiles_W_Z", "Textiles_TextilesID", "dbo.Textiles");
            DropForeignKey("dbo.School_Office_A_B", "SchoolAndOffice_SchoolAndOfficeID", "dbo.SchoolAndOffices");
            DropForeignKey("dbo.School_Office_O_P", "SchoolAndOffice_SchoolAndOfficeID", "dbo.SchoolAndOffices");
            DropForeignKey("dbo.School_Office_L_N", "SchoolAndOffice_SchoolAndOfficeID", "dbo.SchoolAndOffices");
            DropForeignKey("dbo.School_Office_E_K", "SchoolAndOffice_SchoolAndOfficeID", "dbo.SchoolAndOffices");
            DropForeignKey("dbo.School_Office_C_D", "SchoolAndOffice_SchoolAndOfficeID", "dbo.SchoolAndOffices");
            DropForeignKey("dbo.School_Office_Q_Z", "SchoolAndOffice_SchoolAndOfficeID", "dbo.SchoolAndOffices");
            DropForeignKey("dbo.Misc_T_Z", "Miscellaneous_MiscID", "dbo.Miscellaneous");
            DropForeignKey("dbo.Misc_Q_S", "Miscellaneous_MiscID", "dbo.Miscellaneous");
            DropForeignKey("dbo.Misc_P", "Miscellaneous_MiscID", "dbo.Miscellaneous");
            DropForeignKey("dbo.Misc_M_O", "Miscellaneous_MiscID", "dbo.Miscellaneous");
            DropForeignKey("dbo.Misc_G_L", "Miscellaneous_MiscID", "dbo.Miscellaneous");
            DropForeignKey("dbo.Misc_A_F", "Miscellaneous_MiscID", "dbo.Miscellaneous");
            DropForeignKey("dbo.Arts_Crafts_T_Z", "ArtsAndCrafts_ArtsAndCraftsID", "dbo.ArtsAndCrafts");
            DropForeignKey("dbo.Arts_Crafts_R_S", "ArtsAndCrafts_ArtsAndCraftsID", "dbo.ArtsAndCrafts");
            DropForeignKey("dbo.Arts_Crafts_P_Q", "ArtsAndCrafts_ArtsAndCraftsID", "dbo.ArtsAndCrafts");
            DropForeignKey("dbo.Arts_Crafts_D_O", "ArtsAndCrafts_ArtsAndCraftsID", "dbo.ArtsAndCrafts");
            DropForeignKey("dbo.Arts_Crafts_A_C", "ArtsAndCrafts_ArtsAndCraftsID", "dbo.ArtsAndCrafts");
            DropIndex("dbo.Textiles_A_C", new[] { "Textiles_TextilesID" });
            DropIndex("dbo.Textiles_T_V", new[] { "Textiles_TextilesID" });
            DropIndex("dbo.Textiles_P_S", new[] { "Textiles_TextilesID" });
            DropIndex("dbo.Textiles_D_N", new[] { "Textiles_TextilesID" });
            DropIndex("dbo.Textiles_W_Z", new[] { "Textiles_TextilesID" });
            DropIndex("dbo.School_Office_A_B", new[] { "SchoolAndOffice_SchoolAndOfficeID" });
            DropIndex("dbo.School_Office_O_P", new[] { "SchoolAndOffice_SchoolAndOfficeID" });
            DropIndex("dbo.School_Office_L_N", new[] { "SchoolAndOffice_SchoolAndOfficeID" });
            DropIndex("dbo.School_Office_E_K", new[] { "SchoolAndOffice_SchoolAndOfficeID" });
            DropIndex("dbo.School_Office_C_D", new[] { "SchoolAndOffice_SchoolAndOfficeID" });
            DropIndex("dbo.School_Office_Q_Z", new[] { "SchoolAndOffice_SchoolAndOfficeID" });
            DropIndex("dbo.Misc_T_Z", new[] { "Miscellaneous_MiscID" });
            DropIndex("dbo.Misc_Q_S", new[] { "Miscellaneous_MiscID" });
            DropIndex("dbo.Misc_P", new[] { "Miscellaneous_MiscID" });
            DropIndex("dbo.Misc_M_O", new[] { "Miscellaneous_MiscID" });
            DropIndex("dbo.Misc_G_L", new[] { "Miscellaneous_MiscID" });
            DropIndex("dbo.Misc_A_F", new[] { "Miscellaneous_MiscID" });
            DropIndex("dbo.Arts_Crafts_T_Z", new[] { "ArtsAndCrafts_ArtsAndCraftsID" });
            DropIndex("dbo.Arts_Crafts_R_S", new[] { "ArtsAndCrafts_ArtsAndCraftsID" });
            DropIndex("dbo.Arts_Crafts_P_Q", new[] { "ArtsAndCrafts_ArtsAndCraftsID" });
            DropIndex("dbo.Arts_Crafts_D_O", new[] { "ArtsAndCrafts_ArtsAndCraftsID" });
            DropIndex("dbo.Arts_Crafts_A_C", new[] { "ArtsAndCrafts_ArtsAndCraftsID" });
            DropTable("dbo.Textiles_A_C");
            DropTable("dbo.Textiles_T_V");
            DropTable("dbo.Textiles_P_S");
            DropTable("dbo.Textiles_D_N");
            DropTable("dbo.Textiles_W_Z");
            DropTable("dbo.Textiles");
            DropTable("dbo.School_Office_A_B");
            DropTable("dbo.School_Office_O_P");
            DropTable("dbo.School_Office_L_N");
            DropTable("dbo.School_Office_E_K");
            DropTable("dbo.School_Office_C_D");
            DropTable("dbo.School_Office_Q_Z");
            DropTable("dbo.SchoolAndOffices");
            DropTable("dbo.Misc_T_Z");
            DropTable("dbo.Misc_Q_S");
            DropTable("dbo.Misc_P");
            DropTable("dbo.Misc_M_O");
            DropTable("dbo.Misc_G_L");
            DropTable("dbo.Misc_A_F");
            DropTable("dbo.Miscellaneous");
            DropTable("dbo.Arts_Crafts_T_Z");
            DropTable("dbo.Arts_Crafts_R_S");
            DropTable("dbo.Arts_Crafts_P_Q");
            DropTable("dbo.Arts_Crafts_D_O");
            DropTable("dbo.Arts_Crafts_A_C");
            DropTable("dbo.ArtsAndCrafts");
        }
    }
}
