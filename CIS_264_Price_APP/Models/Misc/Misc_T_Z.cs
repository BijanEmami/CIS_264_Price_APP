using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.Misc
{
    public class Misc_T_Z
    {
        [Key]
        public int Misc_T_Z_ID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public string Details { get; set; }
        public virtual Miscellaneous Miscellaneous { get; set; }
    }
}