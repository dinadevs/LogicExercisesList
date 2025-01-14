namespace Step1
{
    public static class Exercise5
    {       
        public static void Run()
        {
            // variables declaration
            double n1, n2;
            //read the variables
            Console.WriteLine("Enter the first note:");
            n1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the second note:");
            n2 = double.Parse(Console.ReadLine());
            //show result   
            Console.WriteLine($"The average between {n1} and {n2} is equal to {(n1 + n2) / 2}");          
        }
    }
}
