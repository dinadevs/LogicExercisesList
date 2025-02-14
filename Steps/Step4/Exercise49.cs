using System;

namespace Step4
{
    public static class Exercise49
    {
        public static void Run()
        {
            Console.WriteLine("\nEnter 6 integers: ");

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine($"number: {i} ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is even! ");
                }
                else
                {
                    Console.WriteLine($"{num} is odd! ");
                }
            }
        }
    }
}
