using System;

namespace Step4
{
    public static class Exercise45
    {
        public static void Run()
        {
            int initialValue;
            int finalValue;
            int increment;

            //initial/final value and reads the values
            Console.WriteLine("\nEnter the initial count value: ");
            initialValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The final value: ");
            finalValue = Convert.ToInt32(Console.ReadLine());
            //increment value
            Console.WriteLine("The increment: ");
            increment = Convert.ToInt32(Console.ReadLine());

            //condition
            if (initialValue < finalValue)
            {   
                //It starts at initialValue, goes to finalValue, and adds the increment. 
                for (int i = initialValue; i <= finalValue; i += increment)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000); // pause for 1000 milliseconds
                }
            }

            else

            Console.WriteLine("\nCounting:");
            
            {   //if the first value greater than last "countdown"
                for (int i = initialValue; i >= finalValue; i -= increment)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000); // pause for 1000 milliseconds
                }
            }

            Console.WriteLine("\nHe finished!");
        }
    }
}
