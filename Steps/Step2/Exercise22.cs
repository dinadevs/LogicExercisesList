namespace Step2
{
    public static class Exercise22
    {
        public static void Run()
        {
            // variables declaration
            int year;
            int currentYear = 2025;

            Console.WriteLine("Year of birth?");
            year = Convert.ToInt32(Console.ReadLine());

            int currentAge = currentYear - year;

            if (currentAge < 18)
            {
                Console.WriteLine($"{18 - currentAge} years left until enlistment.");
            }          
            else 
            {
                Console.WriteLine($"{currentAge - 18} years have passed since enlistment.");
            }
        }
    }
}
