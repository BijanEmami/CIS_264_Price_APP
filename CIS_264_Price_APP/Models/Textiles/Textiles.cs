using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.Textiles
{
    public class Textiles
    {
        [Key]
        public int TextilesID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Textiles_A_C> Textiles_W_Zs { get; set; }
        public virtual ICollection<Textiles_D_N> Textiles_D_Ns { get; set; }
        public virtual ICollection<Textiles_P_S> Textiles_P_Ss { get; set; }
        public virtual ICollection<Textiles_T_V> Textiles_T_Vs { get; set; }
        public virtual ICollection<Textiles_W_Z> Textiles_A_Cs { get; set; }
    }
}