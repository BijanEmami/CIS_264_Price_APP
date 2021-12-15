using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.Plastics
{
    public class Programs
    {
        [Key]
        public int Programs_ID { get; set; }
        public string Category { get; set; }

        public string Name { get; set; }
        public string Price { get; set; }

        public string Details { get; set; }
        public virtual Plastics Plastics { get; set; }
    }
}