using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_p1
{
    public class Guitar : Instrument
    {
        public GuitarSpecs Specs { get; set; }

        public Guitar(
       string serialNumber,
       int price,
       GuitarSpecs specs
            ) : base(serialNumber, price)
        {
            Specs = specs;
        }

    }
}
