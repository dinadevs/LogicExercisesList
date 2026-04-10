using System.Globalization;

namespace Step8
{
    public static class Exercise71
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 8 | Exercise 71 ===");

            int[] num = new int[8];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = 999; //assigns the value 999 to the array
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
        }
    }
}