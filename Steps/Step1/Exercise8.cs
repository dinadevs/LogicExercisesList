namespace Step1
{
    public static class Exercise8
    {       
        public static void Run()
        {
            // variable declaration
            double num;
            //read the variable
            Console.WriteLine("Enter a distance in meters: ");
            num = double.Parse(Console.ReadLine());
            //read distance in meters
            Console.WriteLine($"The distance from {num}m corresponds to: ");
            //show values ​​in other measurements
            Console.WriteLine($"{num / 1000} Km\n {num / 100} Hm\n {num / 10} Dam\n");
            Console.WriteLine($"{num * 10} dm\n {num * 100} cm\n {num * 1000} mm");            
        }
    }
}
