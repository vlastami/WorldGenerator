using System;

namespace WorldGenerator
{
    class Program
    {
        private static GameDirector director = new GameDirector();

        private static int HandleUserInput(int choiceLimit)
        {
            bool inputOK = true;
            int input;
            do
            {
                inputOK = Int32.TryParse(Console.ReadLine(), out input);
                if (inputOK)
                {
                    if (input > choiceLimit || input <= 0)
                    {
                        inputOK = false;
                    }
                }

                if (!inputOK)
                {
                    Console.WriteLine("Select valid value (1-" + choiceLimit + ")");
                }
            } while (!inputOK);

            return input;
        }

        private static void PromptUserToCreateWorld()
        {
            Console.WriteLine("Generate your own world");
            Console.WriteLine("Ready?");
            Console.WriteLine("1 - Desert World");
            Console.WriteLine("2 - Crowded World");
            Console.WriteLine("3 - Tiny World");

            switch (HandleUserInput(3))
            {
                case 1:
                    director.createDesertWorld();
                    break;
                case 2:
                    director.createCrowdedWorld();
                    break;
                case 3:
                    director.createTinyWorld();
                    break;
            }

        }

        private static void ShowWorldStats()
        {
            Console.WriteLine(director.getWorldInfo());
            
        }


        static void Main(string[] args)
        {

            PromptUserToCreateWorld();
            ShowWorldStats();




            


        }
    }



}