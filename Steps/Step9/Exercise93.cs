namespace Step9
{
    public static class Exercise93
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 9 | Exercise 93 ===");

            {
                Console.Write("Enter the start: ");
                int start = int.Parse(Console.ReadLine());

                Console.Write("Enter the end: ");
                int end = int.Parse(Console.ReadLine());

                Console.Write("Enter the increment: ");
                int increment = int.Parse(Console.ReadLine());

                counter(start, end, increment);
            }
            static void counter(int start, int end, int increment)
            {
                // increment is zero
                if (increment == 0)
                {
                    Console.WriteLine("Increment cannot be zero.");
                    return;
                }
                // Countdown 
                if (start < end)
                {
                    for (int i = start; i <= end; i += increment)
                    {
                        Console.WriteLine($"{i}");
                    }
                }
                // Countdown if start is greater than end.
                else
                {
                    for (int i = start; i >= end; i -= increment)
                    {
                        Console.WriteLine($"{i}");
                    }
                }
                Console.WriteLine("End");
            }
        }
    }
}
