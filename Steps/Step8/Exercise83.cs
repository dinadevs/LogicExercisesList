namespace Step8
{
    public static class Exercise83
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 8 | Exercise 83 ===");

           
            int[] num = new int[20];
            Random random = new Random();

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(0, 100); // Generate random numbers
                Console.WriteLine($"{num[i]} ");
            }

            //Sort array 
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        int preview = num[i];
                        num[i] = num[j];
                        num[j] = preview;
                    }
                }
            }
            //sorted numbers
            Console.WriteLine("\n\nSorted numbers:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
        }
    }
}
