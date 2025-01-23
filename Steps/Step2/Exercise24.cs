using System.Diagnostics.CodeAnalysis;

namespace Step2
{
    public static class Exercise24
    {
        public static void Run()
        {
            // variables declaration   
            double kmTrips;

            Console.WriteLine("Distance a passenger wants travel in km?");
            double desiredDistance = double.Parse(Console.ReadLine());

            if (desiredDistance <= 200)
            {
                kmTrips = 0.50;
            }
            else 
            {
                kmTrips = 0.45;
            }

            double ticketPrice = desiredDistance * kmTrips;
    
           Console.WriteLine($"Charging R${kmTrips} per KM \nTicket price {ticketPrice:C}");
        }
    }
}
