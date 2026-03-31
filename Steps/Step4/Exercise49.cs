using System;

namespace Step4
{
    public static class Exercise49
    {
        public static void Run()
        {
            Console.WriteLine("\nEnter 6 integers: ");
            //6 repetitions
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine($"number: {i} ");
                int num = Convert.ToInt32(Console.ReadLine());//number entered

                if (num % 2 == 0)
                {   //If the remainder of the division by 2 is 0, it is an even number.
                    Console.WriteLine($"{num} is even! ");
                }
                else
                { 
                    Console.WriteLine($"{num} is odd! ");//odd
                }
            }
        }
    }
}
