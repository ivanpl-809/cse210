using System;

class Program
{
    static void Main(string[] args)
    {
         {
         Console.Write("Enter your grade percentage: ");
            int percentage = int.Parse(Console.ReadLine());

            string letter;
            string sign = "";

            if (percentage >= 90)
            {
                letter = "A";
            }
            else if (percentage >= 80)
            {
                letter = "B";
            }
            else if (percentage >= 70)
            {
                letter = "C";
            }
            else if (percentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            if (letter != "A" && letter != "F")
            {
                int lastDigit = percentage % 10;

                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }

            else if (letter == "A" && percentage < 93)
            {
                sign = "-";
            }


            Console.WriteLine($"Your grade is: {letter}{sign}");

            if (percentage >= 70)
            {
                Console.WriteLine("Congratulations, you passed the course!");
            }
            else
            {
                Console.WriteLine("Keep trying, you'll get it next time!");
            }
    }
}
}