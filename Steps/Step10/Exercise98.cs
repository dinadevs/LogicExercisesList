using System.Diagnostics.CodeAnalysis;

namespace Step10
{
    public static class Exercise98
    {
        public static void Run()
        {
            {
                Console.WriteLine("=== Step 10 | Exercise 98 ===");

                Console.Write("Enter the first number: ");
                int value1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int value2 = int.Parse(Console.ReadLine());
                /* Calls the 'superAdder' function passing the values
                 sums all the numbers in the range between them*/
                int result = superAdder(value1, value2);

                Console.WriteLine($"The sum is: {result}");
            }// Function that adds the numbers between num1 and num2
            static int superAdder(int num1, int num2)
            {
                int sum = 0;//store the sum
                for (int i = num1; i <= num2; i++)
                {
                    sum += i;
                }
                return sum;
            }
        }
    }
}