namespace Step2
{
    public static class Exercise17
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 2 | Exercise 17 ===");
            // variables declaration
            double currentSpeed;
            //read variable
            Console.WriteLine("Speed of a car?");
            currentSpeed = double.Parse(Console.ReadLine());

            //condition
            if (currentSpeed > 80)
            {
                Console.WriteLine("Speed exceeded!");
                Console.WriteLine($"Fine amount: {(currentSpeed - 80) * 5:F2}");
            }
            else
            {
                Console.WriteLine("Permissible speed!");
            }
        }
    }
}
