namespace Step2
{
    public static class Exercise22
    {
        public static void Run()
        {
            // variables declaration
            int year;
            int currentYear = 2026;
            //It prompts the user for their year of birth and converts the input
            Console.WriteLine("Year of birth?");
            year = Convert.ToInt32(Console.ReadLine());

            int currentAge = currentYear - year;
            //// Checks if the person is under 18 years old
            if (currentAge < 18)
            {
                // Calculates and displays how many years are left until enlistment.
                Console.WriteLine($"{18 - currentAge} years left until enlistment.");
            }          
            else 
            {
                //If you are 18 years of age or older, it calculates and displays how many years have passed since the registration deadline.
                Console.WriteLine($"{currentAge - 18} years have passed since enlistment.");
            }
        }
    }
}
