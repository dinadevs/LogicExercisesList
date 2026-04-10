namespace Step8
{
    public static class Exercise74
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 8 | Exercise 74 ===");

            int[] num = new int[10];

            // Fill array with 5 for even positions and 3 for odd positions
            for (int i = 0; i < num.Length; i++)
            {
                if (i % 2 == 0)
                {
                    num[i] = 5;
                }
                else
                {
                    num[i] = 3;
                }
            }
         
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
        }
    }
}
