using System.Formats.Asn1;

namespace Step1
{
    public static class Exercise10
    {       
        public static void Run()
        {
            // variable declaration
            double height, width;
            //read the variable
            Console.WriteLine("Enter the height of the wall in meters: ");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the wall in meters: ");
            width = double.Parse(Console.ReadLine());
            //declaring and calculating the area
            double area = height * width;
            Console.WriteLine($"Area to be painted: {area} m²");
            //amount of paint needed
            Console.WriteLine($"Quantity of paint required {area / 2} liters");
                     
        }
    }
}
