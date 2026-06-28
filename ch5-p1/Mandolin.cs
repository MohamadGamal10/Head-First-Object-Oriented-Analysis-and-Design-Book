using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_p1
{
    public class Mandolin: Instrument
    {

        public Mandolin(
           string serialNumber,
           int price,
           MandolinSpecs specs
        ): base(serialNumber, price, specs)
        {
        }
    }
}
