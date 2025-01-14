namespace Step1
{
    public static class Exercise4
    {       
        public static void Run()
        {
            // variables declaration
            int n1, n2;
            
            // read both numbers
            Console.WriteLine("Enter the numbers for sum");

            Console.WriteLine("Enter a value: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the other value: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            //sum the variables and display the message          
            Console.WriteLine($"The sum of {n1} and {n2} is equal to {n1 + n2}");
            
        }
    }
}
