using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.Arts_Crafts
{
    public class ArtsAndCrafts
    {
        [Key]
        public int ArtsAndCraftsID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Arts_Crafts_A_C> Arts_Crafts_A_Cs { get; set; }
        public virtual ICollection<Arts_Crafts_D_O> Arts_Crafts_D_Os { get; set; }
        public virtual ICollection<Arts_Crafts_P_Q> Arts_Crafts_P_Qs { get; set; }
        public virtual ICollection<Arts_Crafts_R_S> Arts_Crafts_R_Ss { get; set; }
        public virtual ICollection<Arts_Crafts_T_Z> Arts_Crafts_T_Zs { get; set; }
    }
}