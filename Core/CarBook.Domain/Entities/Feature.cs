﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string FeatureName { get; set; }

        public List<CarFeature> CarFeatures { get; set; } // write it into both of car and feature classes
    }
}
