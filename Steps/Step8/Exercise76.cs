namespace Step8
{
    public static class Exercise76
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 8 | Exercise 76 ===");

            
            int[] num = new int[8];
            Random random = new Random();

            for(int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(50); // Generate random numbers
                Console.WriteLine(num[i]);
            }
            
            for(int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
        }
    }
}
