namespace Step8
{
    public static class Exercise84
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 8 | Exercise 84 ===");

          
            int[] ages = new int[9];
            string[] names = new string[9];
            const int MINORS = 17;

            // Read names and ages 
            for(int i = 0; i < 9; i++)
            {
                Console.Write($"Enter the name of person {i + 1}: ");
                names[i] = Console.ReadLine();

                Console.Write($"Enter the age of {names[i]}: ");
                ages[i] = Convert.ToInt32(Console.ReadLine());
            }
            // minors data
            Console.Write("Data concerning minors: ");
            for(int i = 0; i < 9; i++)
            {
                if(ages[i] <= MINORS)
                {
                   Console.WriteLine($"Name: {names[i]} | Age: {ages[i]}"); 
                }
            }
        }
    }
}
