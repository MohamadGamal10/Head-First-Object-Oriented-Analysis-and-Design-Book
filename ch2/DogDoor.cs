using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2
{
    public class DogDoor
    {
        public bool isOpen { get; set; } = false;

        public void open()
        {
            isOpen = true;
            Console.WriteLine("The dog door opens.");
        }

        public void close()
        {
            isOpen = false;
            Console.WriteLine("The dog door closes.");
        }
    }
}
