using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.ch1
{
    public class Guitar
    {
        public string SerialNumber { get; set; }
        public int Price { get; set; }
        public GuitarSpecs Specs { get; set; }

        public Guitar(
       string serialNumber,
       int price,
       GuitarSpecs specs
            )
        {
            SerialNumber = serialNumber;
            Price = price;
            Specs = specs;
        }

    }
}
