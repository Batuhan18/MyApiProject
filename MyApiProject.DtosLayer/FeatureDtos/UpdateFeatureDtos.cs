﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.DtosLayer.FeatureDtos
{
    public class UpdateFeatureDtos
    {
        public int FeatureId { get; set; }
        public string Title { get; set; }
        public string Head { get; set; }
        public string ImageUrl { get; set; }
    }
}