using System.Formats.Asn1;

namespace Step1
{
    public static class Exercise16
    {       
        public static void Run()
        {
            int cigarettesForDays, yearsOfSmoking;
            // days
            Console.WriteLine("Number of cigarettes smoked per day?");
            cigarettesForDays = Convert.ToInt32(Console.ReadLine());
            //years
            Console.WriteLine("How many years have you smoked?");
            yearsOfSmoking = Convert.ToInt32(Console.ReadLine());
            //values and calculation of the days a smoker
            Console.WriteLine($"cigarettes for days: {cigarettesForDays}\nyears of smoking: {yearsOfSmoking}."); 
            Console.WriteLine($"Days of a smoker's life lost: {cigarettesForDays * yearsOfSmoking * 365 * 10.0 / 1440:F2}");                   
        }
    }
}
