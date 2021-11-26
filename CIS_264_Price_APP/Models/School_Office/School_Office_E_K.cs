using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.School_Office
{
    public class School_Office_E_K
    {
        [Key]
        public int School_Office_E_K_ID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public virtual SchoolAndOffice SchoolAndOffice { get; set; }
    }
}