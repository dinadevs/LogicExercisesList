using System;

namespace Step4
{
    public static class Exercise44
    {
        public static void Run()
        {
            int initialValue;
            int finalValue;
            int increment;

            Console.WriteLine("\nEnter the initial count value: ");
            initialValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The final value: ");
            finalValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The increment: ");
            increment = Convert.ToInt32(Console.ReadLine());

            for (int i = initialValue; i <= finalValue; i += increment)
            {
                Console.Write(i + " ");//shows the count

                Thread.Sleep(1000);//pause for 1000 milliseconds
            }

            Console.WriteLine("\nHe finished!");
        }
    }
}
