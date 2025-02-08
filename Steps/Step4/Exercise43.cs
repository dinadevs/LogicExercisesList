using System;

namespace Step4
{
    public static class Exercise43
    {
        public static void Run()
        {
            Console.WriteLine("\nCountdown from 30 to 1, marking numbers divisible by 4:");
   
            for (int i = 30; i >= 1; i--)
            {
                if (i % 4 == 0)
                {
                    Console.Write($" [{i}]"); // Checks if it is divisible by 4
                }
                else 
                {                
                    Console.Write($" {i}");  // highlights numbers divisible by 4
                }
                Thread.Sleep(1000);//pause for 1000 milliseconds
            }
            Console.WriteLine("\nHe finished!");
        }
    }
}
