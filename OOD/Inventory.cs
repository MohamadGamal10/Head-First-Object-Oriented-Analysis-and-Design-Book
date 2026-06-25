using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    public class Inventory
    {
        private Guitar[] guitars { get; set; }
        public Inventory(Guitar[] guitars)
        {
            this.guitars = guitars;
        }
        public void addGuitar(Guitar guitar)
        {
            guitars = guitars.Append(guitar).ToArray();
        }

        public Guitar? getGuitar(string serialNumber)
        {
            Guitar? guitar = guitars.FirstOrDefault(x => x.SerialNumber == serialNumber);
            if (guitar != null)
            {
                return guitar;
            }
            else
            {
                return null;
            }
        }

        public Guitar[] search(GuitarSpecs serchGuitar)
        {
            Guitar[] result = new Guitar[] { };
            foreach (var item in guitars)
            {
                if(item.Specs.equals(serchGuitar))
                    result = result.Append(item).ToArray();
            }
            return result;
        }


    }
}
