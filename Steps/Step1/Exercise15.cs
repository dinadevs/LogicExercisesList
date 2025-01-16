using System.Formats.Asn1;

namespace Step1
{
    public static class Exercise15
    {       
        public static void Run()
        {
            // variable declaration 
            double days;
            //days
            Console.WriteLine("Days worked in a month:");
            days = double.Parse(Console.ReadLine());
            
            //calculate 8 hours a day and earn R$25 per hour
            Console.WriteLine($"You worked {days} days.\nYour salary this month is: {days * 8 * 25:C}.");
                                  
        }
    }
}
