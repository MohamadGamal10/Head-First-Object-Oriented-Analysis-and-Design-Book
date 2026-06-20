using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    public class BarkSensor
    {
        private readonly DogDoor door;


        public BarkSensor(DogDoor door)
        {
            this.door = door;
        }

        public async Task listen(string bark)
        {
            Console.WriteLine($"captured {bark}");
            await door.open();
        }

    }
}
