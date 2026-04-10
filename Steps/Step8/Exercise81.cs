namespace Step8
{
    public static class Exercise81
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 8 | Exercise 81 ===");

            int[] age = new int[8];
            int sum = 0;
            int maxAge = 0;

            Console.WriteLine("Enter the ages of the people.");

            // Read and validate ages
            for (int i = 0; i < age.Length; i++)
            {
                int input;
                bool valid;
                do
                {
                    Console.Write($"Person {i}: ");
                    string text = Console.ReadLine();

                    valid = int.TryParse(text, out input);

                    if (!valid || input < 0 || input > 140)
                    {
                        Console.WriteLine("Invalid value! Enter a valid age (0–140).");
                    }

                } while (!valid || input < 0 || input > 120);

                age[i] = input;
                sum += age[i];

                if (i == 0 || age[i] > maxAge)
                {
                    maxAge = age[i];
                }
            }
            
            double average = (double)sum / age.Length;
            Console.WriteLine($"\nAverage age: {average:F2}");
            //Positions with people over 25 years old
            Console.WriteLine("\nPositions with people over 25 years old:");
            for (int i = 0; i < age.Length; i++)
            {
                if (age[i] > 25)
                {
                    Console.Write($"{i} ");
                }
            }
            //Oldest age
            Console.WriteLine($"\n\nOldest age entered: {maxAge}");

            //Positions of the oldest age
            Console.WriteLine("\nPositions of the oldest age:");
            for (int i = 0; i < age.Length; i++)
            {
                if (age[i] == maxAge)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
