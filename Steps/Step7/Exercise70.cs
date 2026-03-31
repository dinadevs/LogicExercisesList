namespace Step7
{
    public static class Exercise70
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 7 | Exercise 70 ===");
            // First two terms of the Fibonacci sequence
            int previous = 1; 
            int current = 1;

            for(int i = 0; i < 10; i++)
            {
                Console.Write($"{previous} ");//current term
                int sum = previous + current; // Calculates the next term (sum of the two previous terms)
                // Updates the values ​​for the next iteration
                previous = current; 
                current = sum;
            }
            Console.WriteLine("...");
        }
    }
}