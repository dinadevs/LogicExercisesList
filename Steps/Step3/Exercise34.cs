using System;

namespace Step3
{
    public static class Exercise34
    {
        public static void Run()
        {
            Console.WriteLine("=== Calculate your Body Mass Index (IMC) ===");

            try
            {
                // requests the variables
                Console.WriteLine("Enter your height: ");
                double height = double.Parse(Console.ReadLine());

                Console.Write("Enter your weight: ");
                double weight = double.Parse(Console.ReadLine());
                //calculating BMI
                double bmi = weight / (height * height);

                Console.WriteLine($"\nYour BMI: {bmi:F2}");
                //checking bmi
                if (bmi < 18.5)
                {
                    Console.WriteLine("Underweight");
                }
                else if (bmi >= 18.5 && bmi < 25)
                {
                    Console.WriteLine("Ideal weight");
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    Console.WriteLine("Overweight");
                }
                else if (bmi >= 30 && bmi < 40)
                {
                    Console.WriteLine("Obesity");
                }
                else
                {
                    Console.WriteLine("Morbid obesity");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid input! Please enter numeric values.");
            }
        }
    }
}