﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolioUdemy.DAL.Entities
{
    public class About
    {
        public int AboutID { get; set; }

        public string Title { get; set; }
        public string SubDescription { get; set; }
        public string Details { get; set; }
    }
}
