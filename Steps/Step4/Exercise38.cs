namespace Step4
{
    public static class Exercise38
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 4 | Exercise 38 ===\n");

            
            Console.WriteLine("Count from 6 to 11");
            //causes i to be incremented by 1 with each repetition of the loop
            for (int i = 6; i <= 11; i++)
            {
                Console.Write(i + " ");//shows the count
              
                Thread.Sleep(1000);//pause for 1000 milliseconds
            }
                Console.WriteLine($"He finished!");

        }
    }
}