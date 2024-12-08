using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Mindfulness App");
                Console.WriteLine("Select an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        new BreathingActivity().Start();
                        break;
                    case "2":
                        new ReflectionActivity().Start();
                        break;
                    case "3":
                        new ListingActivity().Start();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }
    }
}