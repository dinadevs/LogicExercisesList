using System.Globalization;

namespace Step8
{
    public static class Exercise75
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 8 | Exercise 75 ===");

            
            int[] num = new int[15];
            num[0] = 1;
            num[1] = 1;
            // Generate Fibonacci sequence
            for (int i = 2; i < num.Length; i++)
            {
                num[i] = num[i - 1] + num[i - 2];
            }
         
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
        }
    }
}
