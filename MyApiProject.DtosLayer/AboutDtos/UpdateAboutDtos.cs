﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.DtosLayer.AboutDtos
{
    public class UpdateAboutDtos
    {
        public int AboutId { get; set; }
        public string OurStory { get; set; }
        public string OurMission { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
    }
}
