namespace Step8
{
    public static class Exercise78
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 8 | Exercise 78 ===");

            int[] num = new int[15];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Integer vector: ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"{num[i]} ");
            }

            Console.WriteLine("Values ​​that are multiples of 10.: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 10 == 0)
                {
                    Console.WriteLine($"Position {i}: Value {num[i]} ");
                }
            }
        }
    }
}
