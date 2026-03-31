namespace Step7
{
    public static class Exercise67
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 7 | Exercise 67 ===");

            Console.WriteLine("Enter the number");
            //converts the entered value to an integer
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                for (int i = 0; i <= number; i++)
                {
                    Console.Write($"Count: {i}, ");
                }

                Console.WriteLine("\nHe finished!");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}