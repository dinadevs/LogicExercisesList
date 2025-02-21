using System;

namespace Step4
{
    public static class Exercise54
    {
        public static void Run()
        {
            //declare and store weight and height variables
            double[] height = new double[7];
            double[] weight = new double[7]; 
            //declare variables
            int weighMoreThan90 = 0;
            int weighLessThan50AndShort = 0; 
            int tallAndHeavy = 0; 
            double totalHeight = 0;

            Console.WriteLine("== Registration for up to 7 people ==");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Enter the weight of person {i + 1} (kg):");
                weight[i] = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the height of person {i + 1} (m):"); 
                height[i] = double.Parse(Console.ReadLine());

                totalHeight += height[i];

                if (weight[i] > 90)
                {
                    weighMoreThan90++;
                }

                if (weight[i] < 50 && height[i] < 1.60) 
                {
                    weighLessThan50AndShort++;
                }

                if (height[i] > 1.90 && weight[i] > 100) 
                {
                    tallAndHeavy++;
                }
            }

            double averageHeight = totalHeight / 7;

            Console.WriteLine("\n==== Results ====");
            Console.WriteLine($"Group height average: {averageHeight:F2} m"); 
            Console.WriteLine($"{weighMoreThan90} people weigh more than 90kg.");
            Console.WriteLine($"{weighLessThan50AndShort} people weigh less than 50kg and are shorter than 1.60m.");
            Console.WriteLine($"{tallAndHeavy} people are taller than 1.90m and weigh more than 100kg."); 
        }
    }
}