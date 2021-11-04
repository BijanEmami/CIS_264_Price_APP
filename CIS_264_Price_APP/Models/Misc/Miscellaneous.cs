using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.Misc
{
    public class Miscellaneous
    {
        [Key]
        public int MiscID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Misc_A_F> Misc_A_Fs { get; set; }
        public virtual ICollection<Misc_G_L> Misc_G_Ls { get; set; }
        public virtual ICollection<Misc_M_O> Misc_M_Os { get; set; }
        public virtual ICollection<Misc_P> Misc_Ps { get; set; }
        public virtual ICollection<Misc_Q_S> Misc_Q_Ss { get; set; }
        public virtual ICollection<Misc_T_Z> Misc_T_Zs { get; set; }
    }
}