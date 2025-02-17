using System;
using System.Collections.Generic;

namespace Step4
{
    public static class Exercise51
    {
        public static void Run()
        {
            double enteredValue;
            //initialize variables
            Console.WriteLine("Enter product prices: $");
            Console.Write("Product 1 price: ");
            enteredValue = double.Parse(Console.ReadLine());

            double highestPrice = enteredValue;
            double lowestPrice = enteredValue;

            // 
            for (int i = 1; i < 8; i++)
            {
                Console.Write($"Product {i + 1} price: $");
                double valueProducts = double.Parse(Console.ReadLine());
                //get the lowest price
                if (valueProducts < lowestPrice)
                {
                    lowestPrice = valueProducts;
                }
                //get the highest price
                if (valueProducts > highestPrice)
                {
                    highestPrice = valueProducts;
                }
            }
            // result
            Console.WriteLine("\n==== Results ====");
            Console.WriteLine($"Lowest priced product: ${lowestPrice:F2}"); 
            Console.WriteLine($"Highest priced product: ${highestPrice:F2}"); 
        }
    }
}
