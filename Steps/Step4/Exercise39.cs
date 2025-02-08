namespace Step4
{
    public static class Exercise39
    {
        public static void Run()
        {
           Console.WriteLine("\nCount 10 to 3");
            //causes i to be decremented by 1 on each repetition of the loop
           for (int i = 10; i >= 3; i--)
           {
                Console.Write(i + " ");//shows the count

                Thread.Sleep(1000);//pause for 1000 milliseconds
           }
           Console.WriteLine("He finished!");
        }
    }
}