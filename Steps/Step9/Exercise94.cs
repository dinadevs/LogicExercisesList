namespace Step9
{
    public static class Exercise94
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 9 | Exercise 94 ===");
            {
                //how many terms
                Console.Write("How many terms of the Fibonacci sequence will be displayed on the screen? ");
                int amount = int.Parse(Console.ReadLine());
                // Call the procedure
                fibonacci(amount);
            }
            static void fibonacci(int terms)
            {
                int previous = 1; // first number
                int current = 1; // second number

                for (int i = 0; i < terms; i++)
                {
                    //current number
                    Console.Write($"{previous} >> ");
                    // Calculates the next value
                    int sum = previous + current;
                    // Updates the values
                    previous = current;
                    current = sum;
                }
                Console.WriteLine("End");
            }
            
        }
    }
}

