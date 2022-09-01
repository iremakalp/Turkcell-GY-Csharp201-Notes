using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    class Parrot:Bird
    {
        public string name;
        public string color;
        public override string makeNoise()
        {
            return "parrot sound";
        }
    }
}
