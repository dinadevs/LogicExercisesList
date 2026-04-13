namespace Step9
{
    public static class Exercise91
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 9 | Exercise 91 ===");

            {
                Console.Write("Enter the first number: ");
                int value1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int value2 = int.Parse(Console.ReadLine());

                bigger(value1, value2);
            }
            static void bigger(int num1, int num2)
            {
                if(num1 > num2)
                {
                    Console.WriteLine($"The greater value is {num1}");
                } 
                else if(num2 > num1)
                {
                    Console.WriteLine($"The greater value is {num2}");
                }
                else
                {
                    Console.WriteLine($"The values are equal");
                }
            }
        }
    }
}
