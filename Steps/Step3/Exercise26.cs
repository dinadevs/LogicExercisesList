namespace Step3
{
    public static class Exercise26
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 3 | Exercise 26 ===");

            Console.Write("Enter the first integer: ");
            int firstNumber  = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int secondNumber  = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber )
            {
                Console.WriteLine($"{firstNumber} is greater than {secondNumber }");
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine($"{secondNumber } is greater than {firstNumber}");
            }
            else
            {
                Console.WriteLine($"{firstNumber} is {secondNumber } are equal ");
            }
        }
    }
}