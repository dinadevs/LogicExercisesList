namespace Step9
{
    public static class Exercise92
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 9 | Exercise 92 ===");
            {
                Console.Write("Enter the number: ");
                int number = int.Parse(Console.ReadLine());
                evenOrOdd(number);
            }
            static void evenOrOdd(int value)
            {
                if(value % 2 == 0)
                {
                    Console.WriteLine($"{value} it's even");
                } 
                else
                {
                    Console.WriteLine($"{value} it's odd");
                }
            }

        }
    }
}
