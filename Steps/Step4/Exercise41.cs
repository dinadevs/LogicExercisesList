namespace Step4
{
    public static class Exercise41
    {
        public static void Run()
        {
            Console.WriteLine("\nCount from 100 to 0, 5 by 5");

            //causes i to be decremented by 5 with each repetition of the loop
            for (int i = 100; i >= 0; i -= 5)
            {
                Console.Write(i + " ");//shows the count

                Thread.Sleep(1000);//pause for 1000 milliseconds
            }
            Console.WriteLine("He finished!");
        }
    }
}