namespace Step7
{
    public static class Exercise68
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 7 | Exercise 68 ===");

            int totalWomen = 0;
            double sumWeightWomen = 0;
            int menOver100kg = 0;
            int maxWeightMen = 0;

            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine($"--- Person {i} ---");
                
                Console.Write("Enter sex [W/M]: ");
                char sex = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine(); // Line break after KeyChar

                Console.Write("Enter weight (kg): ");
                // Validation of the entered number
                if (int.TryParse(Console.ReadLine(), out int weight))
                {
                    if (sex == 'W')
                    {
                        totalWomen++; // Count one more woman
                        sumWeightWomen += weight; // Add the weight
                    }
                    else if (sex == 'M')
                    {
                        if (weight > 100)// if the weight is greater than 100kg
                        {
                            menOver100kg++; 
                        }
                        // greater weight men
                        if (weight > maxWeightMen)
                        {
                            maxWeightMen = weight;// Update the highest weight
                        }
                    }
                }
                Console.WriteLine();
            }
            //average and avoid division by zero
            double averageWeightWomen = totalWomen > 0 ? sumWeightWomen / totalWomen : 0;

            Console.WriteLine($"a) Total women registered: {totalWomen}");
            Console.WriteLine($"b) Average weight among women: {averageWeightWomen:F2} kg");
            Console.WriteLine($"c) Men weighing more than 100kg: {menOver100kg}");
            Console.WriteLine($"d) Heaviest weight among men: {maxWeightMen} kg");
        }
    }
}