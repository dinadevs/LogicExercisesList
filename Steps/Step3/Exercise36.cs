using System;

namespace Step3
{
    public static class Exercise36
    {
        public static void Run()
        {
            Console.WriteLine("=== Physical activity points ===");

            try
            {   // declaring and reading variables 
                Console.Write("How many hours of activity did you have in the month? ");
                double activityHours = double.Parse(Console.ReadLine());

                double points;
                //checking points per hour
                if (activityHours <= 10)
                {
                    points = 2;
                }
                else if (activityHours > 10 && activityHours <= 20)
                {
                    points = 5;
                }
                else
                {
                    points = 10;
                }
                //Calculates total points
                double totalPoints = activityHours * points;
                //calculate total money
                double EarnedMoneyhour = totalPoints * 0.05;

                Console.WriteLine("\n=== Earning Summary ===");
                Console.WriteLine($"Points: {totalPoints}");
                Console.WriteLine($"totalGain: {EarnedMoneyhour}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid input! Please enter numeric values.");
            }
        }
    }
}
