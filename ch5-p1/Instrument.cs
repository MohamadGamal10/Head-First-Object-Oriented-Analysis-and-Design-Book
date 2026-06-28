using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_p1
{
    public abstract class Instrument
    {
        public string SerialNumber { get; set; }
        public int Price { get; set; }
        public InstrumentSpecs Specs { get; set; }

        public Instrument(
       string serialNumber,
       int price,
       InstrumentSpecs specs
        )
        {
            SerialNumber = serialNumber;
            Price = price;
            Specs = specs;
        }
    }
}
