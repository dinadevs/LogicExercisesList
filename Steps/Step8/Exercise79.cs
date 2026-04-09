using System.ComponentModel.DataAnnotations;

namespace Step8
{
    public static class Exercise79
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 8 | Exercise 79 ===");

            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                int value;
                bool valid;

                do
                {
                    Console.Write($"Enter the number for position {i}: ");
                    string input = Console.ReadLine();

                    valid = int.TryParse(input, out value);

                    if (!valid)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid integer.");
                    }

                } while (!valid);

                num[i] = value;
            }

            Console.WriteLine("\nEven numbers:");

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine($"Position {i}: Number {num[i]}");
                }
            }

        }
    }
}
