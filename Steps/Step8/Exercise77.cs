namespace Step8
{
    public static class Exercise77
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 8 | Exercise 77 ===");

            string[] name = new string[7];

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write("Enter your name: ");
                name[i] = Console.ReadLine();
            }
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }

        }
    }
}
