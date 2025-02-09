using System;

namespace Step4
{
    public static class Exercise46
    {
        public static void Run()
        {
            int sum = 0;
            Console.WriteLine("\nCalculating the sum of 6 + 8 + 10 + ... + 100:");

            for (int i = 6; i <= 100; i += 2)
            {
                sum += i;

            }
            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}
