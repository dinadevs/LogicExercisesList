namespace Step7
{
    public static class Exercise65
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 7 | Exercise 65 ===");

            const int LIMIT = 100;
            const int STEP = 10; 
            // starts at 100 and goes down to 0, decreasing by 10 each time.
            for(int i = LIMIT; i >= 0; i -= STEP)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("He finished!");
        }
    }
}