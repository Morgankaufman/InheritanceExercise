using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public bool canFly { get; set; }

        public bool migrates { get; set; }

        public string height { get; set; }

        public string wingSpan { get; set; }

    }
}
