using System.Formats.Asn1;

namespace Step1
{
    public static class Exercise13
    {       
        public static void Run()
        {
            // variable declaration
            double wage;
            //read the variable
            Console.WriteLine("Enter salary:");
            wage = double.Parse(Console.ReadLine());
            //calculate increase
            double salary_increase = wage * 15 / 100;
            Console.WriteLine($"Increase {salary_increase:C}");
            //final value
            double new_salary = wage + salary_increase; 
            Console.WriteLine($"The final value with a 15% increase will be {new_salary:C}");                               
        }
    }
}
