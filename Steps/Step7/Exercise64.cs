namespace Step7
{
    public static class Exercise64
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 7 | Exercise 64 ===");
        
            const int STOP_NUMBER = 40;
            const int INTERVALO_NUMBER = 5;
            //starts at 0, goes up to 40, increases by 5 each time
            for(int i = 0; i <= STOP_NUMBER; i += INTERVALO_NUMBER)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("He finished!");
        }
    }
}