using System;
using System.Threading;

namespace MindfulnessApp
{
    public class ReflectionActivity : Activity
    {
        private static readonly string[] Prompts = new string[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private static readonly string[] Questions = new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "How can you keep this experience in mind in the future?"
        };

        protected override string GetDescription()
        {
            return "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }

        protected override void PerformActivity()
        {
            Random random = new Random();
            string prompt = Prompts[random.Next(Prompts.Length)];

            Console.Clear();
            Console.WriteLine(prompt);
            Thread.Sleep(3000);

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(DurationInSeconds);

            while (DateTime.Now < endTime)
            {
                string question = Questions[random.Next(Questions.Length)];
                Console.Clear();
                Console.WriteLine(question);
                ShowSpinner();
                Thread.Sleep(3000);
            }
        }

        private void ShowSpinner()
        {
            string[] spinner = new string[] { "/", "-", "\\", "|" };
            foreach (var item in spinner)
            {
                Console.Write(item);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }
}