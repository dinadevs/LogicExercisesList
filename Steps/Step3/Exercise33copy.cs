using System;

namespace Step3
{
    public static class Exercise33
    {
        public static void Run()
        {
            Console.WriteLine("===== Loan for Home Purchase =====");

            try
            {
                // requests the variables
                Console.WriteLine("Enter the value of the house: ");
                double homeValue = double.Parse(Console.ReadLine());

                Console.Write("Enter your salary: ");
                double buyerSalary = double.Parse(Console.ReadLine());

                Console.Write("In how many years do you want to pay? ");
                int installmentsYears = Convert.ToInt32(Console.ReadLine());
                //Calculate the monthly installment
                double monthlyInstallments = homeValue / (installmentsYears * 12);

                double maximumLimit = buyerSalary * 0.30;
                //calculated values
                Console.WriteLine("\n=== Loan Analysis ===");
                Console.WriteLine($"Monthly Installment: ${monthlyInstallments:F2}");
                Console.WriteLine($"Maximum Allowed: ${maximumLimit:F2}");
                //Check the loan
                if (monthlyInstallments <= maximumLimit)
                {
                    Console.WriteLine("Loan approved!");
                }
                else
                {
                    Console.WriteLine("Loan not approved!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid input! Please enter numeric values.");
            }
        }
    }
}
