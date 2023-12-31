﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVideoGameLibrary.Shared
{
    public class VideoGame
    {
        public int id { get; set; }     
        public required string Title { get; set; }
        public string Publisher { get; set; } = string.Empty;

        public int ReleaseYear { get; set; }

        public string Comments { get; set; } = string.Empty;



    }
}
