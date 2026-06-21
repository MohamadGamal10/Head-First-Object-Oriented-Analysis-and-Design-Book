using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    public class BarkSensor
    {
        private readonly DogDoor door;

        public BarkSensor(DogDoor door)
        {
            this.door = door;
        }

        public async Task listen(Bark bark)
        {
            Console.WriteLine($"captured {bark.Sound}");

            var allowedBarks = door.allowedBarks;

            foreach (var item in allowedBarks)
            {
                if (item.equals(bark))
                {
                    await door.open();
                    return;
                }
               
            }


        }

    }
}
