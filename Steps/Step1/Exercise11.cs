using System.Formats.Asn1;

namespace Step1
{
    public static class Exercise11
    {       
        public static void Run()
        {
            // variable declaration
            int A, B, C;
            //read the variable
            Console.WriteLine("Equation to show the delta value.");
            Console.WriteLine("Enter the value of A ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of B: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of C: ");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Values ​​of {A}, {B} and {C}");
            //the equation
            int delta = (B * B) - (4 * A * C);
            //Delta value.
            Console.WriteLine($"Delta value {delta}");
                     
        }
    }
}
