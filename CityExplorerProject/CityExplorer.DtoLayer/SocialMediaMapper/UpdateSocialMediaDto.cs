﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DtoLayer.SocialMediaMapper
{
    public class UpdateSocialMediaDto
    {
        public int SocialMediaID { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
}
