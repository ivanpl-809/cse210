using System;
using System.Threading;

namespace MindfulnessApp
{
    public class BreathingActivity : Activity
    {
        protected override string GetDescription()
        {
            return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        protected override void PerformActivity()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(DurationInSeconds);

            while (DateTime.Now < endTime)
            {
                Console.Clear();
                Console.WriteLine("Breathe in...");
                ShowCountdown();
                Thread.Sleep(1000);

                Console.Clear();
                Console.WriteLine("Breathe out...");
                ShowCountdown();
                Thread.Sleep(1000);
            }
        }

        private void ShowCountdown()
        {
            for (int i = 3; i > 0; i--)
            {
                Console.Write($"{i}... ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
