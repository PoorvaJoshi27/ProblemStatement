﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemStatement.Models
{
    public class AdminModel
    {
        public int B_no { get; set; }
        public string Product { get; set; }
        public Decimal? Price { get; set; }
        public DateTime Date { get; set; }
    }
}