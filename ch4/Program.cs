namespace ch4
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            //ch 4
            DogDoor door = new DogDoor();

            Bark barkWoof = new Bark("Woof!");
            Bark barkHawhaw = new Bark("hawhaw!");
            Bark barkNighbor = new Bark("hufff!");

            door.addBark(barkWoof);
            door.addBark(barkHawhaw);

            BarkSensor sensor = new BarkSensor(door);

            await sensor.listen(barkWoof); // captured Woof! The dog door opens. (and closes after 5 seconds)
            
            Console.WriteLine("================================");

            await sensor.listen(barkNighbor); // not captured, the dog door does not open


        }
    }
}
