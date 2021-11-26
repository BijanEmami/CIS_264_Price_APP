using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.Textiles
{
    public class Textiles_T_V
    {
        [Key]
        public int Textiles_T_V_ID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public virtual Textiles Textiles { get; set; }
    }
}