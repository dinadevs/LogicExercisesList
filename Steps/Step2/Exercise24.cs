using System.Diagnostics.CodeAnalysis;

namespace Step2
{
    public static class Exercise24
    {
        public static void Run()
        {
            const double LIMITE_DISTANCIA = 200.0;
            const double PRECO_KM_CURTO = 0.50;
            const double PRECO_KM_LONGO = 0.45;
            // variables declaration   
            double kmValue;
            // Asks the user for the distance of the trip.
            Console.WriteLine("Distance a passenger wants travel in km?");
            double desiredDistance = double.Parse(Console.ReadLine());
            //Condition for setting the distance-based fare
            if (desiredDistance <= LIMITE_DISTANCIA)
            {
                //For short trips (up to 200km), the cost is 50 cents per km.
                kmValue = PRECO_KM_CURTO;
            }
            else
            {
                //For long trips (over 200km), the cost drops to 45 cents per km.
                kmValue = PRECO_KM_LONGO;
            }
            // Calculates the total cost by multiplying the distance traveled by the set fare.
            double ticketPrice = desiredDistance * kmValue;
            //Displays the final fare amount.
            Console.WriteLine($"Charging R${kmValue} per KM \nTicket price {ticketPrice:C}");
        }
    }
}
