using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.School_Office
{
    public class SchoolAndOffice
    {
        [Key]
        public int SchoolAndOfficeID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<School_Office_A_B> School_Office_Q_Zs { get; set; }
        public virtual ICollection<School_Office_C_D> School_Office_C_Ds { get; set; }
        public virtual ICollection<School_Office_E_K> School_Office_E_Ks { get; set; }
        public virtual ICollection<School_Office_L_N> School_Office_L_Ns { get; set; }
        public virtual ICollection<School_Office_O_P> School_Office_O_Ps { get; set; }
        public virtual ICollection<School_Office_Q_Z> School_Office_A_Bs { get; set; }

    }
}