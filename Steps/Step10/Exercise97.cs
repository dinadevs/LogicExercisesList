using System.IO.Pipelines;

namespace Step10
{
    public static class Exercise97
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 10 | Exercise 97 ===");

            {
                Console.Write("Enter the first number: ");
                int value1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int value2 = int.Parse(Console.ReadLine());

                Console.Write("Enter the third number: ");
                int value3 = int.Parse(Console.ReadLine());
                // Calls the 'bigger' function to find the largest value
                int result = bigger(value1, value2, value3);

                Console.WriteLine($"The greater value is: {result}");
            }// Function that identifies the largest
            static int bigger(int num1, int num2, int num3)
            {
                int biggerNumber; //variable stores largest number
                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine($"The greater value is {num1}");
                    biggerNumber = num1;
                }
                else if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine($"The greater value is {num2}");
                    biggerNumber = num2;
                }
                else
                {
                    Console.WriteLine($"The greater value is {num3}");
                    biggerNumber = num3;
                }
                if (num1 == num2 && num2 == num3)
                {
                    Console.WriteLine("All values are equal");
                }
                return biggerNumber;
            }
        }
    }
}