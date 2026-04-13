namespace Step9
{
    public static class Exercise90
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 9 | Exercise 90 ===");

            {
                Console.Write("Enter the first number: ");
                int value1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int value2 = int.Parse(Console.ReadLine());

                summer(value1, value2);// Calls the method passing the values
            }
            // Method that adds and displays the result
            static void summer(int num1,int num2)
            {
                int sum = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {sum}");// Show the sum
            }
        }
    }
}
