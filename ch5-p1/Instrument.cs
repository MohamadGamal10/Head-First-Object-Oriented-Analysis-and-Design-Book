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

        public Instrument(
       string serialNumber,
       int price
            )
        {
            SerialNumber = serialNumber;
            Price = price;
        }
    }
}
