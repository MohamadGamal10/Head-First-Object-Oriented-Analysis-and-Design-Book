using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ch5_p1
{
    public class Inventory
    {
        private Instrument[] instruments { get; set; }
        public Inventory(Instrument[] instruments)
        {
            this.instruments = instruments;
        }

        public void addInstrument(string serialNumber, int price, InstrumentSpecs specs)
        {
            if (specs is GuitarSpecs guitarSpecs)
            {
                instruments = instruments.Append(new Guitar(serialNumber, price, guitarSpecs)).ToArray();
            }
            else if (specs is MandolinSpecs mandolinSpecs)
            {
                instruments = instruments.Append(new Mandolin(serialNumber, price, mandolinSpecs)).ToArray();
            }
        }

        // return instrument
        public Instrument? getGuitar(string serialNumber)
        {
            Instrument? instrument = instruments.FirstOrDefault(x => x.SerialNumber == serialNumber);
            if (instrument != null)
            {
                return instrument;
            }
            else
            {
                return null;
            }
        }

        // return guitar[] or instrument[]
        public T[] search<T>(InstrumentSpecs serchInstrument) where T : Instrument
        {
            List<T> result = new List<T>();
            foreach (var item in instruments)
            {
                if (item is T instrument && instrument.Specs.equals(serchInstrument))
                    result.Add(instrument);
            }
            return result.ToArray();
        }

    }
}
