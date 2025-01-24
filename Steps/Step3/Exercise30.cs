using System.Diagnostics.CodeAnalysis;

namespace Step3
{
    public static class Exercise30
    {
        public static void Run()
        {
            // Variables declaration   
            Console.WriteLine("Enter a size of three line segments:");

            Console.WriteLine("Segment 1:");
            int segmentOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segment 2:");
            int segmentTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segment 3:");
            int segmentThree = Convert.ToInt32(Console.ReadLine());

            // Check if it forms a triangle
            if (segmentOne + segmentTwo > segmentThree &&
                segmentOne + segmentThree > segmentTwo &&
                segmentTwo + segmentThree > segmentOne)
            {
                //determine the triangle
                string type = (segmentOne == segmentTwo && segmentOne == segmentThree) ? "Equilateral" :
                              (segmentOne == segmentTwo || segmentOne == segmentThree || segmentTwo == segmentThree) ? "Isosceles" : "Scalene";

                Console.WriteLine($"It is possible to form a {type} triangle with: {segmentOne}, {segmentTwo}, {segmentThree}");
            }
            else
            {
                Console.WriteLine($"It is not possible to form a triangle with: {segmentOne}, {segmentTwo}, {segmentThree}");
            }
        }
    }
}
