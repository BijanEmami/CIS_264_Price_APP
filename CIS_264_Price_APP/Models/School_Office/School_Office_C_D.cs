﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CIS_264_Price_APP.Models.School_Office
{
    public class School_Office_C_D
    {
        [Key]
        public int School_Office_C_D_ID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual SchoolAndOffice SchoolAndOffice { get; set; }
    }
}