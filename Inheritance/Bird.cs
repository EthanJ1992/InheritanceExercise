using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool CanFly { get; set; }
        public bool EatsMeat { get; set; }
        public int WingSpan { get; set; }
        public bool IsSmall { get; set; }
      
    }
}
