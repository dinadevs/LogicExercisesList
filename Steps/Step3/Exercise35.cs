using System;

namespace Step3
{
    public static class Exercise35
    {
        public static void Run()
        {
            Console.WriteLine("===== Rent a Car =====");

            try
            {   // declaring and reading variables 
                Console.Write("Type of car desired (popular or luxury): ");
                string desiredCar = Console.ReadLine();

                Console.Write("How many days of rent? ");
                int rentalDays = int.Parse(Console.ReadLine());

                Console.Write("How many km were covered? ");
                double kmTraveled = double.Parse(Console.ReadLine());
                //variable daily cost
                double dailyRate = 0;
                //variable Kilometer rate
                double kmRate = 0;
                //checking price by type of car
                if (desiredCar.Equals("popular", StringComparison.OrdinalIgnoreCase))
                {
                    dailyRate = 90.0;
                    kmRate = (kmTraveled <= 100) ? 0.20 : 0.10;
                }
                else if (desiredCar.Equals("luxury", StringComparison.OrdinalIgnoreCase))
                {
                    dailyRate = 150.0;
                    kmRate = (kmTraveled <= 200) ? 0.30 : 0.25;
                }
                else
                {
                    Console.WriteLine("Invalid car type. Please enter 'popular' or 'luxury'.");
                }
                //Total price calculation
                double totalPay = (rentalDays * dailyRate) + (kmTraveled * kmRate);
                //result
                Console.WriteLine("\n=== Rental Summary ===");
                Console.WriteLine($"Car: {desiredCar}");
                Console.WriteLine($"Days: {rentalDays}");
                Console.WriteLine($"Distance traveled: {kmTraveled} km");
                Console.WriteLine($"Total price: ${totalPay:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid input! Please enter numeric values.");
            }
        }
    }
}
