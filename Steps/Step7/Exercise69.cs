namespace Step7
{
    public static class Exercise69
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 7 | Exercise 69 ===");

            int[] term = new int[10];//store 10 terms
            //entry term                       
            Console.Write("First, type the term from the sequence: ");
            term[0] = Convert.ToInt32(Console.ReadLine());
            //entry reason
            Console.Write("Common ratio of the sequence: ");
            int reason = Convert.ToInt32(Console.ReadLine());

            int sum = term[0];//add to the first term
            // Calculates the next terms of the PA.
            for(int i = 1; i < 10; i++)
            {   // PA formula
                term[i] = term[i - 1] + reason;
                sum += term[i]; //Sum the terms.
            }
            Console.Write("PA: ");
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"{term[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sequence sum: {sum}");
        }
    }
}