﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _15_TopSpotsAPI.Models
{
    public class TopSpot
    {
        public string name { get; set; }
        public string description { get; set; }
        public double[] location { get; set; }
    }
}