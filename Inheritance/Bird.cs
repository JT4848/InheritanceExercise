using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool DoesItFly { get; set; }
        public string Name { get; set; }
        public bool IsLarge { get; set; }
        public string Weight { get; set; }

    }
}
