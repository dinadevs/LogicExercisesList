namespace Step10
{
    public static class Exercise95
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 10 | Exercise 95 ===");
            {
                Console.Write("Enter the first number: ");
                int value1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int value2 = int.Parse(Console.ReadLine());
                /* Calls the 'adder' function, passes the values
                   and stores the sum in the 'result' variable*/
                int result = adder(value1, value2);

                Console.WriteLine($"The sum is: {result}");
            }// Function that adds numbers
            static int adder(int num1, int num2)           
            {   
                //performs and returns the sum
                int sum = num1 + num2;
                return sum;
            }

        }
    }
}