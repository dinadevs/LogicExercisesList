using System;

namespace Step3
{
    public static class Exercise37
    {
        public static void Run()
        {
            Console.WriteLine("=== Physical activity points ===");

            try
            {   // declaring and reading variables 
                Console.Write("Current employee salary: ");
                double currentSalary = double.Parse(Console.ReadLine());

                Console.Write("Gender (Woman, Man): ");
                string gender = Console.ReadLine();

                Console.Write("Years in the company: ");
                int yearsWorked = Convert.ToInt32(Console.ReadLine());

                double salaryIncrease = 0;
                //checking gender
                if (gender.Equals("Woman", StringComparison.OrdinalIgnoreCase))
                {   // Increase based on gender and years worked
                    salaryIncrease = (yearsWorked < 15) ? 0.05 :
                                     (yearsWorked <= 20) ? 0.12 : 0.23;
                }
                else if (gender.Equals("Man", StringComparison.OrdinalIgnoreCase))
                {
                    salaryIncrease = (yearsWorked < 20) ? 0.03 :
                                     (yearsWorked <= 30) ? 0.13 : 0.25;
                }
                else
                {
                    Console.WriteLine("Invalid gender input. Please enter 'Woman' or 'Man'.");
                    return;
                }
                //calculating new salary value
                double newSalary = currentSalary * (1 + salaryIncrease);

                Console.WriteLine("\n==== Salary Adjustment ====");
                Console.WriteLine($"Increase Percentage: {salaryIncrease * 100}%");
                Console.WriteLine($"New Salary: ${newSalary:F2}");

            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid input! Please enter numeric values.");
            }
        }
    }
}
