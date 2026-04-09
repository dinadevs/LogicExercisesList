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

            for (int i = 0; i < age.Length; i++)
            {
                Console.Write($"Person {i}: ");
                age[i] = Convert.ToInt32(Console.ReadLine());

                sum += age[i];

                if (i == 0 || age[i] > maxAge)
                {
                    maxAge = age[i];
                }
            }

            double average = (double)sum / age.Length;
            Console.WriteLine($"\nAverage age: {average:F2}");

            Console.WriteLine("\nPositions with people over 25 years old:");
            for (int i = 0; i < age.Length; i++)
            {
                if (age[i] > 25)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine($"\n\nOldest age entered: {maxAge}");

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
