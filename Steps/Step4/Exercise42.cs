namespace Step4
{
    public static class Exercise42
    {
        public static void Run()
        {
            Console.WriteLine("\nEnter a positive integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //causes the number entered to be increased by 1 with each repetition of the loop
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + " ");//shows the count

                Thread.Sleep(1000);//pause for 1000 milliseconds
            }
            Console.WriteLine("He finished!");
        }
    }
}