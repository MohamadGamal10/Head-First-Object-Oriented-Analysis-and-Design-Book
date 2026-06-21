using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    public class Remote
    {
        public DogDoor door { get; set; }
        public int Pass { get; set; } = 4444;

        public Remote(DogDoor door)
        {
            this.door = door;
        }

        public async Task toggle(int? pass = null)
        {
            if (pass != null)
            {
                if (pass != Pass)
                {
                    Console.WriteLine("Wrong password");
                    return;
                }
            }

            if (door.isOpen)
            {
                door.close();
                return;
            }
            else
            {
                await door.open();
            }
        }

        public async Task toggleJam()
        {
            await door.open();
        }

    }
}
