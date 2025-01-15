namespace Step1
{
    public static class Exercise7
    {       
        public static void Run()
        {
            // variable declaration
            double num;
            //read the variable
            Console.WriteLine("Enter a number: ");
            num = double.Parse(Console.ReadLine());
            //show double
            Console.WriteLine($"Twice as much {num} is {num * 2}");
            //The third part 
            Console.WriteLine($"The third part of {num} is {num / 3}");
            
        }
    }
}
