namespace Step8
{
    public static class Exercise80
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 8 | Exercise 80 ===");

            int[] number = new int[30];
            Random random = new Random();

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(1, 16);
                Console.WriteLine(number[i]);
            }

            Console.WriteLine("Enter a number from 1 to 15.: ");
            int entryNumber = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (entryNumber == number[i])
                {
                    Console.WriteLine($"Position {i}");
                    count++;
                }
            }
            Console.WriteLine($"\n{entryNumber} appeared {count} times.");
        }
    }
}
