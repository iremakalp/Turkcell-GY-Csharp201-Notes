using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    class Bird
    {
        public string kind;
        public int speed;
        public double weight;

        public virtual string makeNoise()
        {
            return "sound";
        }
    }
}
