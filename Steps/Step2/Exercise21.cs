namespace Step2
{
    public static class Exercise21
    {
        public static void Run()
        {
            // variables declaration
            int year;
            
            Console.WriteLine("Enter a year to find out if it is LEAP.");
            year = Convert.ToInt32(Console.ReadLine());
            //First condition. Checks if the year is a leap year 
            if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year!");
            }
            //second condition
            else
            {
                Console.WriteLine($"{year} not leap year!");
            }
        }
    }
}
