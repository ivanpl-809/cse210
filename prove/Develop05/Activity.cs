using System;

namespace MindfulnessApp
{
    public abstract class Activity
    {
        public int DurationInSeconds { get; set; }

        public virtual void Start()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {GetType().Name}!");
            Console.WriteLine(GetDescription());
            Console.WriteLine("Please enter the duration in seconds:");
            if (int.TryParse(Console.ReadLine(), out int duration))
            {
                DurationInSeconds = duration;
            }
            else
            {
                Console.WriteLine("Invalid input, setting duration to 10 seconds.");
                DurationInSeconds = 10;
            }
            Console.WriteLine("Get ready...");
            Thread.Sleep(2000);

            PerformActivity();

            Finish();
        }

        protected virtual void PerformActivity()
        {
            // This will be implemented in derived classes
        }

        private void Finish()
        {
            Console.Clear();
            Console.WriteLine($"Well done! You completed the {GetType().Name} for {DurationInSeconds} seconds.");
            Thread.Sleep(2000);
        }

        protected abstract string GetDescription();
    }
}