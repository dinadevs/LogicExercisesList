using System.Formats.Asn1;

namespace Step1
{
    public static class Exercise16
    {       
        public static void Run()
        {
            const int DAYS_PER_YEAR = 365;
            const int MINUTES_LOST_PER_CIGARRETES = 10;
            const int MINUTES_PER_DAY = 1440;

            int cigarettesForDays, yearsOfSmoking;
            // days
            Console.WriteLine("Number of cigarettes smoked per day?");
            cigarettesForDays = Convert.ToInt32(Console.ReadLine());
            //years
            Console.WriteLine("How many years have you smoked?");
            yearsOfSmoking = Convert.ToInt32(Console.ReadLine());
            //values and calculation of the days a smoker
            Console.WriteLine($"cigarettes for days: {cigarettesForDays}\nyears of smoking: {yearsOfSmoking}."); 
            Console.WriteLine($"Days of a smoker's life lost: {cigarettesForDays * yearsOfSmoking * DAYS_PER_YEAR * MINUTES_LOST_PER_CIGARRETES/MINUTES_PER_DAY:F2}");                   
        }
    }
}
