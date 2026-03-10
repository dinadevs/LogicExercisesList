using System;

namespace Step5
{
    public static class Exercise57
    {
        public static void Run()
        {
            double totalMenSalary = 0;
            double totalWomenSalary = 0;
            string continueOption;

            Console.WriteLine("=== Step 5 | Exercise 57 ===");

            do
            {
                //  salary reading with validation
                Console.Write("\nEnter the employee's salary: ");
                double salary = double.Parse(Console.ReadLine());

                // sex and validation
                char sex;
                while (true)
                {
                    Console.Write("Type [F] for Female or [M] for Male: ");
                    string input = Console.ReadLine().ToUpper();
                    
                    if (input.Length > 0 && (input[0] == 'F' || input[0] == 'M'))
                    {
                        sex = input[0];
                        break;
                    }
                    Console.WriteLine("<<ERROR>> Invalid input!");
                }

                // totals
                if (sex == 'F') totalWomenSalary += salary;
                else totalMenSalary += salary;

                // ask if you want to continue.
                Console.Write("\nDo you want to continue? [Y/N]: ");
                continueOption = Console.ReadLine().ToUpper();

            } while (continueOption == "Y");

            // final showing
            Console.WriteLine("\n--- FINAL RESULTS ---");
            Console.WriteLine($"Total wages paid to men: {totalMenSalary:C}");
            Console.WriteLine($"Total wages paid to women: {totalWomenSalary:C}");
        }
    }
}