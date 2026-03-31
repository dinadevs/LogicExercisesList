using System;

namespace Step6
{
    public static class Exercise63
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 6 | Exercise 63 ===");
            
            char response;
            int sumNumbers = 0;
            int totalNumbers = 0;
            int evenNumbers = 0;
            int smallestNumber = 0;

            do
            {
                Console.Write("Enter the number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                totalNumbers++;// Increases quantity
                sumNumbers += number;//add the number

                if (totalNumbers == 1 || number < smallestNumber)
                {
                    smallestNumber = number;
                }
                //checks if it's even
                if (number % 2 == 0)
                {
                    evenNumbers++;
                }

                Console.WriteLine("Do you want to continue? [Y/N]");
                response = Console.ReadLine()[0];
            // Continues as long as you answer Y or y
            } while (response == 'y' || response == 'Y');

            double average = totalNumbers > 0 ? (double)sumNumbers / totalNumbers : 0;

            Console.WriteLine($"Sum of the values: {sumNumbers}");
            Console.WriteLine($"Smallest value entered: {smallestNumber}");
            Console.WriteLine($"Average of the values: {average:F2}");
            Console.WriteLine($"Even values: {evenNumbers}");
        }
    }
}