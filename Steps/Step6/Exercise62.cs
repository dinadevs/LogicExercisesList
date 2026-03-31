namespace Step6
{
    public static class Exercise62
    {
        public static void Run()
        {
            char response;
            int totalAges = 0;
            double sumAges = 0;
            int agesOver21 = 0;

            Console.WriteLine("=== Step 6 | Exercise 62 ===");
            do
            {
                Console.WriteLine("Enter the age: ");

                int age = Convert.ToInt32(Console.ReadLine());

                totalAges++;//increases the total number of people
                sumAges += age;//add the age to the total.

                Console.Write("Do you want to continue? [Y/N] ");
                response = Console.ReadLine()[0];

                if (age >= 21)
                {
                    agesOver21++;
                }
            //Continues as long as you answer Y or y
            } while (response == 'y' || response == 'Y');

            double average = (double)sumAges / totalAges;

            Console.WriteLine($"Total ages entered: {totalAges}");
            Console.WriteLine($"Average age: {average:F2}");
            Console.WriteLine($"People aged 21 or older: {agesOver21}");
        }
    }
}