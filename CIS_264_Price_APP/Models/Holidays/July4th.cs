using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.Holidays
{
    public class July4th
    {
        [Key]
        public int July4th_ID { get; set; }
        public string Category { get; set; }

        public string Name { get; set; }
        public string Price { get; set; }
        public virtual Holidays Holidays { get; set; }
    }
}