using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        bool continueInput = true;
        while (continueInput)
        {
            Console.WriteLine("Enter activity type (Running, Cycling, Swimming):");
            string activityType = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the date (YYYY-MM-DD):");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the duration in minutes:");
            int duration = int.Parse(Console.ReadLine());
            if (activityType == "running")
            {
                Console.WriteLine("Enter the distance in miles:");
                double distance = double.Parse(Console.ReadLine());
                activities.Add(new Running(date, duration, distance));
            }
            else if (activityType == "cycling")
            {
                Console.WriteLine("Enter the speed in mph:");
                double speed = double.Parse(Console.ReadLine());
                activities.Add(new Cycling(date, duration, speed));
            }
            else if (activityType == "swimming")
            {
                Console.WriteLine("Enter the number of laps:");
                int laps = int.Parse(Console.ReadLine());
                activities.Add(new Swimming(date, duration, laps));
            }
            Console.WriteLine("Do you want to add another activity? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                continueInput = false;
            }
        }
        Console.WriteLine("\nActivity Summaries:");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
