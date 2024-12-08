using System;
using System.Threading;

namespace MindfulnessApp
{
    public static class Utilities
    {
        public static void Pause(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        public static void ShowSpinner()
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
