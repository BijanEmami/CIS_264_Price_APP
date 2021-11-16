using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.Plastics
{
    public class Plastics
    {
        [Key]
        public int Holidays_ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Products> Productss { get; set; }
        public virtual ICollection<Programs> Programss { get; set; }
    }
}