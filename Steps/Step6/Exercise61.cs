namespace Step6
{
    public static class Exercise61
    {
        public static void Run()
        {
            int num = 0;
            const int STOP_NUMBER = 30;
            const int INTERVALO_NUMBER = 3;

            Console.WriteLine("=== Step 6 | Exercise 61 ===");

            do
            {
                Console.Write(num + " ");
                num = num + INTERVALO_NUMBER;
            } while (num <= STOP_NUMBER);
            
            Console.WriteLine("He finished!");
        }
    }
}