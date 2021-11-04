using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.Arts_Crafts
{
    public class Arts_Crafts_R_S
    {
        [Key]
        public int Arts_Crafts_R_S_ID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual ArtsAndCrafts ArtsAndCrafts { get; set; }
    }
}