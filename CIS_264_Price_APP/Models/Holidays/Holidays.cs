using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.Holidays
{
    public class Holidays
    {
        [Key]
        public int Holidays_ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Halloween> Halloweens { get; set; }
        public virtual ICollection<July4th> July4ths { get; set; }
        public virtual ICollection<St> Sts { get; set; }
        public virtual ICollection<Valentines> Valentiness { get; set; }
        public virtual ICollection<XmasandNewYear> XmasandNewYears { get; set; }
    }
}