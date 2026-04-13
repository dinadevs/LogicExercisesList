namespace Step9
{
    public static class Exercise89
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 9 | Exercise 89 ===");

            void generator(string message, int time, int edge)
            {
                string line;
                // Choose the border type (line)
                switch (edge)
                {
                    case 1:
                        line = "+-------=======------+";
                        break;
                    case 2:
                        line = "~~~~~~~~:::::::~~~~~~~";
                        break;
                    case 3:
                        line = "<<<<<<<<------->>>>>>>";
                        break;
                    default:// If edge is any other value, use this style.
                        line = "----------------------";
                        break;
                }

                Console.WriteLine(line);
                for (int i = 0; i < time; i++)//time: the number of times the text will be repeated
                {
                    Console.WriteLine($"   {message}");//message: displayed text
                }
                Console.WriteLine(line);
            }
             // Method call
            generator("Chosen edge", 3, 2);//Call 4 times
        }
    }
}