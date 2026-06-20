using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    public class DogDoor
    {
        public bool isOpen { get; set; } = false;

        public async Task open()
        {
            isOpen = true;
            Console.WriteLine("The dog door opens.");

            await Task.Delay(5000);

            this.close();
        }

        public void close()
        {
            isOpen = false;
            Console.WriteLine("The dog door closes.");
        }
    }
}
