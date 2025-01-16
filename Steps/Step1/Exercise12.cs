using System.Formats.Asn1;

namespace Step1
{
    public static class Exercise12
    {       
        public static void Run()
        {
            // variable declaration
            double product;
            //read the variable
            Console.WriteLine("Enter the value of the product:");
            product = double.Parse(Console.ReadLine());
            //calculate discount
            double discount = product * 5 / 100;
            Console.WriteLine($"With a 5% discount, you save {discount:C}");
            //final value
            double final_value = product - discount; 
            Console.WriteLine($"Amount to be paid {final_value:C}");          
                     
        }
    }
}
