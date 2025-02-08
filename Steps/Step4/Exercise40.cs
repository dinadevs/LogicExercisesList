namespace Step4
{
    public static class Exercise40
    {
        public static void Run()
        {
           Console.WriteLine("\nCount from 0 to 18, 3 by 3");
            //causes i to be incremented by 3 with each repetition of the loop
           for (int i = 0; i <= 18; i += 3)
           {
            Console.Write(i + " ");//shows the count

            Thread.Sleep(1000);//pause for 1000 milliseconds
           }
           Console.WriteLine("He finished!");
        }
    }
}