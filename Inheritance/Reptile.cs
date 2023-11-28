using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string weight { get; set; }

        public bool venom { get; set; }

        public int speed { get; set; }
        
        public string length { get; set; }
    }
}
