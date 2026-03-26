using System.Diagnostics.CodeAnalysis;

namespace Step2
{
    public static class Exercise25
    {
        public static void Run()
        {
            // variables declaration   
            Console.WriteLine("Enter a size of three line segments:");
            //It requests and converts segment numbers to integers.
            Console.WriteLine("n°1:");
            int segmentOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("n°2:");
            int segmentTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("n°3:");
            int segmentThree = Convert.ToInt32(Console.ReadLine());
            /* Application of the Triangle Inequality: To form a triangle, the sum of two sides must ALWAYS be greater than the third side */
            if (segmentOne + segmentTwo > segmentThree && segmentOne + segmentThree > segmentTwo && segmentTwo + segmentThree > segmentOne)
            {
                Console.WriteLine($"It is possible to form a triangle with: {segmentOne}, {segmentTwo}, {segmentThree}");
            }
            else
            {
                Console.WriteLine($"Cannot form a triangle with: {segmentOne}, {segmentTwo}, {segmentThree}");
            }
        }
    }
}
