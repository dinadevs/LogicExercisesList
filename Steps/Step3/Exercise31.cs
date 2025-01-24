using System;

namespace Step3
{
    public static class Exercise31
    {
        public static void Run()
        {
            // Variables declaration   
            Console.WriteLine("Choose between Rock, Paper, or Scissors:");
            Console.WriteLine("Enter the desired number:");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");

            Console.Write("Number entered: ");
            int playerChoice = Convert.ToInt32(Console.ReadLine());

            // Validate player choice
            if (playerChoice < 1 || playerChoice > 3)
            {
                Console.WriteLine("Invalid choice. Please choose 1, 2, or 3.");
                return;
            }
            // Generate computer choice
            Random random = new Random();
            int computerChoice = random.Next(1, 4); 

            // Convert choices to text
            string[] choices = { "Rock", "Paper", "Scissors" };
            string playerOption = choices[playerChoice - 1];
            string computerOption = choices[computerChoice - 1];

            // Display choices
            Console.WriteLine($"You chose: {playerOption}");
            Console.WriteLine($"Computer chose: {computerOption}");

            // Determine winner
            if (playerChoice == computerChoice)
            {
                Console.WriteLine("It's a draw!");
            }
            else if ((playerChoice == 1 && computerChoice == 3) ||  // Rock beats Scissors
                     (playerChoice == 2 && computerChoice == 1) ||  // Paper beats Rock
                     (playerChoice == 3 && computerChoice == 2))    // Scissors beat Paper
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }
        }
    }
}
