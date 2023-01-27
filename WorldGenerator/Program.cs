namespace WorldGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select a world to create: 1. Desert, 2. Ocean");
            var input = Console.ReadLine();
            IWorldBuilder selectedBuilder;
            switch (input)
            {
                case "1":
                    selectedBuilder = new DesertWorldBuilderBuilder();
                    break;
                case "2":
                    selectedBuilder = new OceanWorldBuilderBuilder();
                    break;
                default:
                    Console.WriteLine("Invalid selection, please enter 1 or 2.");
                    return;
            }

            Director director = new Director();
            WorldBuilder myWorldBuilder = director.constructWorld(selectedBuilder);

            
            Console.WriteLine("Tree count: " + myWorldBuilder.treeCount);
            Console.WriteLine("Water percent: "+ myWorldBuilder.waterPercent);
            
        }
    }
}