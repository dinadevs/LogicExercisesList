namespace Step9
{
    public static class Exercise88
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 9 | Exercise 88 ===");

            void generator(string message, int time)//takes two parameters
            {
                Console.WriteLine("+-------=======------+");
                for (int i = 0; i < time; i++) //time: the number of times the text will be repeated
                {
                    Console.WriteLine($"   {message}");//message: displayed text
                }
                Console.WriteLine("+-------=======------+");
            }
            // Method call
            generator("Learning C#", 4);//Call 4 times
        }
    }
}
