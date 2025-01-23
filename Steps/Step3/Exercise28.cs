namespace Step3
{
    public static class Exercise28
    {
        public static void Run()
        {
            Console.WriteLine("Land Area Calculator");

            //Reads width and length
            Console.Write("Enter the width of the land (m): ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of the land (m): ");
            double length = double.Parse(Console.ReadLine());

            double area = width * length;
            //// Classify the land based on the area
            if (area < 100)
            {
                Console.WriteLine($"The land has an area of {area:F2}m².\nClassification: Popular Land.");
            }
            else if (area <= 500)
            {
                Console.WriteLine($"The land has an area of {area:F2}m².\nClassification: Master Land.");
            }
            else
            {
                Console.WriteLine($"The land has an area of {area:F2}m².\nClassification: VIP Land.");
            }
        }
    }
}