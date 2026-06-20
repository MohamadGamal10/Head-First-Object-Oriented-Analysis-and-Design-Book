namespace ch3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            //ch 3
            DogDoor door = new DogDoor();
            BarkSensor sensor = new BarkSensor(door);
            await sensor.listen("Woof!"); // captured Woof! The dog door opens. (and closes after 5 seconds)

            //ch 2
            //DogDoor door = new DogDoor();
            //Remote remote = new Remote(door);
            //await remote.toggle();

            //Console.WriteLine("================================");

            //await remote.toggleJam();
            //await remote.toggle();

            //Console.WriteLine("=================================");

            //await remote.toggle(1234);
            //await remote.toggle(4444);

        }
    }
}
