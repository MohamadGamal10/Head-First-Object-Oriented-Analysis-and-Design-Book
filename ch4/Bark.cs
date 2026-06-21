using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    public class Bark
    {
        public string Sound { get; set; }

        public Bark(string sound)
        {
            Sound = sound;
        }

        public bool equals(Bark bark)
        {
            return Sound.ToLower() == bark.Sound.ToLower();
        }
    }
}
