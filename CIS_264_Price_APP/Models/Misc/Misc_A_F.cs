using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.Misc
{
    public class Misc_A_F
    {
        [Key]
        public int Misc_A_F_ID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual Miscellaneous Miscellaneous { get; set; }
    }
}