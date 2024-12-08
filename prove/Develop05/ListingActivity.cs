using System;
using System.Threading;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        private static readonly string[] Prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        protected override string GetDescription()
        {
            return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }

        protected override void PerformActivity()
        {
            Random random = new Random();
            string prompt = Prompts[random.Next(Prompts.Length)];

            Console.Clear();
            Console.WriteLine(prompt);
            Thread.Sleep(2000);

            Console.WriteLine("You have 10 seconds to start thinking...");
            Thread.Sleep(10000);

            int itemCount = 0;
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(DurationInSeconds);

            while (DateTime.Now < endTime)
            {
                Console.Clear();
                Console.WriteLine("Enter an item (or press Enter to stop):");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;

                itemCount++;
            }

            Console.Clear();
            Console.WriteLine($"You listed {itemCount} items.");
            Thread.Sleep(2000);
        }
    }
}
