namespace Step8
{
    public static class Exercise73
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 8 | Exercise 73 ===");

            int[] num = new int[10];

            // Display array in reverse order
            for(int i = num.Length - 1; i >= 0; i--) {
              Console.Write($"{i} ");
            }
        }
    }
}
