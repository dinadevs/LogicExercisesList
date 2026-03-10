using System;

namespace Step5
{
    public static class Exercise60
    {
        public static void Run()
        {
        
            string oldestPersonName = "";
            int oldestAge = -1;

            string youngestWomanName = "";
            int youngestWomanAge = int.MaxValue;

            int sumAgeGroup = 0;
            int totalPeople = 0;
            int menOver30 = 0;
            int womenUnder18 = 0;

            Console.WriteLine("=== Step 5 | Exercise 60 ===");

            while (true)
            {
                Console.Write("\nEnter the name: ");
                string name = Console.ReadLine();

                Console.Write("Enter the age: ");
                if (!int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.WriteLine("Invalid input. Age must be a number.");
                    continue;
                }

                Console.Write("Type [F] for Female and [M] for Male: ");
                char sex = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                // older person
                totalPeople++;
                sumAgeGroup += age;

                // older person
                if (age > oldestAge)
                {
                    oldestAge = age;
                    oldestPersonName = name;
                }

                if (sex == 'F')
                {
                    // Name of the youngest woman
                    if (age < youngestWomanAge)
                    {
                        youngestWomanAge = age;
                        youngestWomanName = name;
                    }
                    // Women under 18
                    if (age < 18) womenUnder18++;
                }

                // Men over 30 years old
                if (sex == 'M' && age > 30)
                {
                    menOver30++;
                }

                Console.Write("\nDo you want to continue? [Y/N]: ");
                char resp = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (resp == 'N') break;
            }

            Console.WriteLine("\n------- FINAL RESULTS -------");
            Console.WriteLine($"a) Name of the oldest person: {oldestPersonName} ({oldestAge} years)");
            
            if (!string.IsNullOrEmpty(youngestWomanName))
                Console.WriteLine($"b) Name of the youngest woman: {youngestWomanName} ({youngestWomanAge} years)");
            else
                Console.WriteLine("b) No women were registered.");

            if (totalPeople > 0)
                Console.WriteLine($"c) Average age of the group: {(double)sumAgeGroup / totalPeople:F2}");

            Console.WriteLine($"d) Men over 30 years old: {menOver30}");
            Console.WriteLine($"e) Women under 18 years old: {womenUnder18}");
        }
    }
}