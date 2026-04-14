namespace Step10
{
    public static class Exercise99
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 10 | Exercise 99 ===");

            {
                Console.Write("Enter the base: ");
                int support = int.Parse(Console.ReadLine());

                Console.Write("Enter the exponent: ");
                int exponent = int.Parse(Console.ReadLine());
                // Calls the 'power' function to calculate the power.
                int result = power(support, exponent);

                Console.WriteLine($"Result of exponentiation: {result}");
            }// Function that calculates the power
            static int power(int num1, int num2)
            {
                /* Uses the Math.Pow function to calculate the power
                   Math.Pow returns a value*/
                double exponentiation = Math.Pow(num1, num2);
                // Converts the result from double to int before returning
                return (int)exponentiation; ;
            }

        }
    }
}