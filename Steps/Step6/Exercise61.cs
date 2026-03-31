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
                Console.Write(num + " ");//current value
                num = num + INTERVALO_NUMBER;//add 3 for each repetition
            } while (num <= STOP_NUMBER);//continues as long as num is less than or equal to 30
            
            Console.WriteLine("He finished!");
        }
    }
}