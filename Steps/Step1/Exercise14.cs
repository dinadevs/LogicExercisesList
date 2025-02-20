using System.Formats.Asn1;

namespace Step1
{
    public static class Exercise14
    {       
        public static void Run()
        {
            // variable declaration
            double km; 
            int days;
            // days
            Console.WriteLine("Number of days:");
            days = Convert.ToInt32(Console.ReadLine());
            //km traveled 
            Console.WriteLine("Number of km traveled:");
            km = double.Parse(Console.ReadLine());
            //calculate total price R$90 per day and R$0.20 per km
            Console.WriteLine($"The car was rented for {days} days and traveled {km} km. The total amount payable is: {(days * 90) + (km * 0.20):C}.");

                                    
        }
    }
}
