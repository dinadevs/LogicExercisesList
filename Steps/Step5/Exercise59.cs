using System;

namespace Step5
{
    public static class Exercise59
    {
        public static void Run()
        {
            int olderAge = 0; 
            int youngerWoman = int.MaxValue; 
            int registeredMen = 0; 
            int somaAgeMen = 0; 
            bool womanFound = false; // if there is any woman

            Console.WriteLine("=== Step 5 | Exercise 59 ===");

            while (true)
            {
                // age
                Console.Write("\nEnter the age: ");
                if (!int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                    continue;
                }
                
                // sex
                Console.Write("Type [F] for Female and [M] for Male: ");
                char sex = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                //Older age 
                if (age > olderAge) olderAge = age;

                //logic for Men 
                if (sex == 'M')
                {
                    registeredMen++;
                    somaAgeMen += age;
                }

                // younger woman
                if (sex == 'F')
                {
                    womanFound = true;
                    if (age < youngerWoman) youngerWoman = age;
                }

                // stop condition
                Console.Write("\nDo you want to continue? [Y/N]: ");
                char resp = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (resp == 'N') break;
            }

            Console.WriteLine("\n------- RESULTS -------");
            Console.WriteLine($"a) Oldest age recorded: {olderAge}");
            Console.WriteLine($"b) Total men registered: {registeredMen}");
            
            if (womanFound)
                Console.WriteLine($"c) Youngest woman's age: {youngerWoman}");
            else
                Console.WriteLine("c) No women were registered.");

            if (registeredMen > 0)
                Console.WriteLine($"d) Average age among men: {(double)somaAgeMen / registeredMen:F2}");
            else
                Console.WriteLine("d) No men were registered to calculate average.");

        } 
    } 
} 