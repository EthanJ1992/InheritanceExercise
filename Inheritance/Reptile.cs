using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool LivesInWater { get; set; }
        public bool Crawls { get; set; }
        public bool HasShell { get; set; }
        public bool IsLarge { get; set; }


    }
}
