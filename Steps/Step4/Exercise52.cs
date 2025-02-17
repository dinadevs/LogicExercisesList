using System;
using System.Collections.Generic;

namespace Step4
{
    public static class Exercise52
    {
        public static void Run()
        {
            int totalAge = 0;
            int overEighteen = 0;
            int underFive = 0;
            int olderAge = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Age of person {i + 1}: ");
                int ageEntered = Convert.ToInt32(Console.ReadLine());

                //sum of the average
                totalAge += ageEntered;

                //Counts ages over 18 years old
                if (ageEntered > 18)
                {
                    overEighteen++;
                }
                //Counts ages under 5 years old
                if (ageEntered < 5)
                {
                    underFive++;
                }
                //oldest age entered
                if (ageEntered > olderAge)
                {
                    olderAge = ageEntered;
                }
            }
            //average age
            double averageAge = totalAge / 10.0;
            // result
            Console.WriteLine("\n==== Results ====");
            Console.WriteLine($"Average age of the group: {averageAge:F1}");
            Console.WriteLine($"How many are over 18 years old: {overEighteen}");
            Console.WriteLine($"How many are under 5 years old: {underFive}");
            Console.WriteLine($"Older age: {olderAge}");
        }
    }
}
