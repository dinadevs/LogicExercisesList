using System.Diagnostics.CodeAnalysis;

namespace Step2
{
    public static class Exercise24
    {
        public static void Run()
        {
            // variables declaration   
            double kmValue;
            // Asks the user for the distance of the trip.
            Console.WriteLine("Distance a passenger wants travel in km?");
            double desiredDistance = double.Parse(Console.ReadLine());
            //Condition for setting the distance-based fare
            if (desiredDistance <= 200)
            {
                //For short trips (up to 200km), the cost is 50 cents per km.
                kmValue = 0.50;
            }
            else
            {
                //For long trips (over 200km), the cost drops to 45 cents per km.
                kmValue = 0.45;
            }
            // Calculates the total cost by multiplying the distance traveled by the set fare.
            double ticketPrice = desiredDistance * kmValue;
            //Displays the final fare amount.
            Console.WriteLine($"Charging R${kmValue} per KM \nTicket price {ticketPrice:C}");
        }
    }
}
