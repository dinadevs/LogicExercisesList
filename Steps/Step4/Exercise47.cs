using System;

namespace Step4
{
    public static class Exercise47
    {
        public static void Run()
        {
            int sum = 0;
            Console.WriteLine("\nCalculating the sum of 500 + 450 + 400 + ... + 50 + 0: ");

            for (int i = 500; i >= 0; i += 50)
            {
                sum += i; // Accumulate the sum
            }
            Console.WriteLine($"= {sum}"); //end result
        }
    }
}
