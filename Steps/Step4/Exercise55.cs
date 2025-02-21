using System;

namespace Step3
{
    public static class Exercise55
    {
        public static void Run()
        {
            //Improve the game that of exercise 32

            Random random = new Random();
            List<int> drawnNumbers = new List<int>();
            int hits = 0;

            Console.WriteLine("=== Try to find out what it was! ===");
            Console.WriteLine("Enter a number between 1 and 10:");

            // Input player choice
            Console.Write("Number entered: ");
            int playerChoice = Convert.ToInt32(Console.ReadLine());

            // Validating
            if (playerChoice < 1 || playerChoice > 10)
            {
                Console.WriteLine("Invalid choice. Only numbers from 1 to 10 are allowed.");
                return;
            }

            for (int i = 1; i < 4; i++)
            {
                int computerChoice = random.Next(1, 11);
                drawnNumbers.Add(computerChoice);

                Console.WriteLine($"\nRound {i}: \nDrawing number...");
                Thread.Sleep(1000);

                Console.WriteLine($"You chose: {playerChoice}");
                Console.WriteLine($"The computer chose: {computerChoice}");
                //validate entry
                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("You got it right!");
                    hits++;
                }
                else
                {
                    Console.WriteLine("You were wrong!");
                }
            }
            Console.WriteLine($"\nDrawn numbers: {string.Join(", ", drawnNumbers)}");
            Console.WriteLine($"You got it right {hits} .");
        }
    }
}
