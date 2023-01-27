namespace WorldGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select a world to create: 1. Desert, 2. Ocean");
            var input = Console.ReadLine();
            IWorldBuilder selectedBuilder;
            switch (input)
            {
                case "1":
                    selectedBuilder = new DesertWorldBuilder();
                    break;
                case "2":
                    selectedBuilder = new OceanWorldBuilder();
                    break;
                default:
                    Console.WriteLine("Invalid selection, please enter 1 or 2.");
                    return;
            }

            Director director = new Director();
            WorldBuilder myWorldBuilder = director.ConstructWorld(selectedBuilder);
            
            Console.WriteLine("Generated World");
            Console.WriteLine("Tree count: " + myWorldBuilder.TreeCount);
            Console.WriteLine("Water percent: "+ myWorldBuilder.WaterPercent);
            Console.WriteLine("Size: " + myWorldBuilder.Size);
        }
    }
}