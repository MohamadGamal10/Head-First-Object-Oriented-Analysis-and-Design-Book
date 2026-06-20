namespace ch2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            await remote.toggle(); // The dog door opens. (and closes after 5 seconds)

            Console.WriteLine("================================");

            remote.toggleJam(); // The dog door opens. (and stays open)
            await remote.toggle(); // The dog door closes.

            Console.WriteLine("=================================");

            await remote.toggle(1234); // Wrong password
            await remote.toggle(4444); // The dog door opens. (and closes after 5 seconds)

        }
    }
}
