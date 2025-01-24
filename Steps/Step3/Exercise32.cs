using System;

namespace Step3
{
    public static class Exercise32
    {
        public static void Run()
        {
            Console.WriteLine("=== Try to find out what it was! ===");
            Console.WriteLine("Enter a number between 1 and 5:");

            // Input player choice
            Console.Write("Number entered: ");
            int playerChoice = Convert.ToInt32(Console.ReadLine());

            // Validating
            if (playerChoice < 1 || playerChoice > 5)
            {
                Console.WriteLine("Invalid choice. Only numbers from 1 to 5 are allowed.");
                return;
            }

            // Generate computer's random choice
            Random random = new Random();
            int computerChoice = random.Next(1, 6);

            // Display choices
            Console.WriteLine($"You chose: {playerChoice}");
            Console.WriteLine($"The computer chose: {computerChoice}");

            // Determine the result
            if (playerChoice == computerChoice)
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("You were wrong!");
            }
        }
    }
}
