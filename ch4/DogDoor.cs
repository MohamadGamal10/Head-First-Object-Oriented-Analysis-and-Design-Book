using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    public class DogDoor
    {
        public bool isOpen { get; set; } = false;
        public Bark[] allowedBarks { get; set; } = [];

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

        public void addBark(Bark bark)
        {
            var list = allowedBarks.ToList();
            list.Add(bark);
            allowedBarks = list.ToArray();
        }
    }
}
