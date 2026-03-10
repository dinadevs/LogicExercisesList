using System;
using System.Collections.Generic;

namespace Step5
{
    public static class Exercise56
    {
        public static void Run()
        {
            int num;
            int sum = 0;
            int toGoOut = 1111;
            List<int> drawnNumbers = new List<int>();

            Console.WriteLine("=== Step 5 | Exercise 56 ===");
            Console.WriteLine("Enter numbers to be summed:\nType 1111 to exit.");

            while (true)
            {
                Console.Write("Enter a number: ");

                // invalid input
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    continue;
                }
                // Check condition
                if (num == toGoOut)
                {
                    Console.WriteLine("\nProgram interrupted.");
                    break;
                }
                // Add number to list
                drawnNumbers.Add(num);
                // add the numbers
                sum += num;
            }
            Console.WriteLine($"\nNumbers entered: {string.Join(", ", drawnNumbers)}");
            Console.WriteLine($"Sum of numbers: {sum}");
        }
    }
}
