using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVideoGameLibrary.Shared
{
    public class AthensCity
    {
        public int id { get; set; }
        public required string PlaceName { get; set; }
        public string sights { get; set; } = string.Empty;

        public int DistanceFromTheMetro { get; set; }

        public string Comments { get; set; } = string.Empty;
    }
}
