namespace Step9
{
    public static class Exercise86
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 9 | Exercise 86 ===");

            void generator()//declare the method
            {   //message to be displayed
                Console.WriteLine("+-------=======------+");
                Console.WriteLine("    Hello World!");
                Console.WriteLine("+-------=======------+");
            }
            generator();//method call
        }
    }
}
