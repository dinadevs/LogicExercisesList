namespace Step7
{
    public static class Exercise66
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 7 | Exercise 66 ===");
            // Enter and read the multiplication table number
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= 10; i++)
            {
               int result = number * i;// Calculates the multiplication
                 
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }
}