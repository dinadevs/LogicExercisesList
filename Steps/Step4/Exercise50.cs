using System;
using System.Collections.Generic;

namespace Step4
{
    public static class Exercise50
    {
        public static void Run()
        {
            Random random = new Random();
            List<int> drawnNumbers = new List<int>(); //creates a list to store the numbers entered
            int aboveFive = 0; //accumulates the numbers drawn above 5
            int divisibleThree = 0; //accumulates the drawn numbers divisible by 3

            Console.WriteLine("\n====  Number draw  ==== ");
            Console.WriteLine("The program will draw 20 numbers between 0 and 10. ");

            Thread.Sleep(2000);

            // Draw 20 numbers
            for (int i = 0; i < 20; i++)
            {
                int computerChoice = random.Next(0, 11); // Generates a number between 0 and 10
                drawnNumbers.Add(computerChoice); //the number drawn by computerChoice is added to the list

                if (computerChoice > 5)
                {
                    aboveFive++;
                }

                if (computerChoice % 3 == 0)
                {
                    divisibleThree++;
                }
            }
            // result
            Console.WriteLine($"\nDrawn numbers: {string.Join(", ", drawnNumbers)}"); //list of drawn numbers
            Thread.Sleep(1000);
            Console.WriteLine($"Numbers above 5: {aboveFive}"); 
            Thread.Sleep(1000);
            Console.WriteLine($"Numbers divisible by 3: {divisibleThree}"); 
        }
    }
}
