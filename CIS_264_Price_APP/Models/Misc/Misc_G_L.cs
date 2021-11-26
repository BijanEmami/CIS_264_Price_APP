using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.Misc
{
    public class Misc_G_L
    {
        [Key]
        public int Misc_G_L_ID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public virtual Miscellaneous Miscellaneous { get; set; }
    }
}