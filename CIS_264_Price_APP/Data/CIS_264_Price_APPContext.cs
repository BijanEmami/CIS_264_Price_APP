using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CIS_264_Price_APP.Data
{
    public class CIS_264_Price_APPContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CIS_264_Price_APPContext() : base("name=CIS_264_Price_APPContext")
        {
        }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Arts_Crafts.ArtsAndCrafts> ArtsAndCrafts { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Misc.Miscellaneous> Miscellaneous { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.School_Office.SchoolAndOffice> SchoolAndOffices { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Textiles.Textiles> Textiles { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Arts_Crafts.Arts_Crafts_A_C> Arts_Crafts_A_C { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Arts_Crafts.Arts_Crafts_D_O> Arts_Crafts_D_O { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Arts_Crafts.Arts_Crafts_P_Q> Arts_Crafts_P_Q { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Arts_Crafts.Arts_Crafts_R_S> Arts_Crafts_R_S { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Arts_Crafts.Arts_Crafts_T_Z> Arts_Crafts_T_Z { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Misc.Misc_A_F> Misc_A_F { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Misc.Misc_G_L> Misc_G_L { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Misc.Misc_M_O> Misc_M_O { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Misc.Misc_P> Misc_P { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Misc.Misc_Q_S> Misc_Q_S { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Misc.Misc_T_Z> Misc_T_Z { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.School_Office.School_Office_A_B> School_Office_A_B { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.School_Office.School_Office_C_D> School_Office_C_D { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.School_Office.School_Office_E_K> School_Office_E_K { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.School_Office.School_Office_L_N> School_Office_L_N { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.School_Office.School_Office_O_P> School_Office_O_P { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.School_Office.School_Office_Q_Z> School_Office_Q_Z { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Textiles.Textiles_A_C> Textiles_A_C { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Textiles.Textiles_D_N> Textiles_D_N { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Textiles.Textiles_P_S> Textiles_P_S { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Textiles.Textiles_T_V> Textiles_T_V { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Textiles.Textiles_W_Z> Textiles_W_Z { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Holidays.Holidays> Holidays { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Holidays.Halloween> Halloweens { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Holidays.July4th> July4th { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Holidays.Valentines> Valentines { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Holidays.St> Sts { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Holidays.XmasandNewYear> XmasandNewYears { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Plastics.Plastics> Plastics { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Plastics.Programs> Programs { get; set; }

        public System.Data.Entity.DbSet<CIS_264_Price_APP.Models.Plastics.Products> Products { get; set; }
    }
}
