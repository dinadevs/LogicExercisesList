namespace Step9
{
    public static class Exercise87
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 9 | Exercise 87 ===");

            void generator(string message)//method with parameter
            {
                Console.WriteLine("+-------=======------+");
                Console.WriteLine($"    {message}");
                Console.WriteLine("+-------=======------+");
            }
            generator("Learning C#");//method call with parameter
        }
    }
}
