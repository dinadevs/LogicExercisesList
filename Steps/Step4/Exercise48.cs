using System;

namespace Step4
{
    public static class Exercise48
    {
        public static void Run()
        {
            int sum = 0;

            //insert 7 variables
            Console.WriteLine("\nEnter 7 integers: ");

            //repeat the loop from 1 to 7
            for (int i = 1; i <= 7; i++) 
            {   
                //Asks the user for a number
                Console.WriteLine($"number: {i} ");
                int num = Convert.ToInt32(Console.ReadLine());

                //add entered numbers
                sum += num;
            }
            Console.Write($"result : " + sum);
        }
    }
}
