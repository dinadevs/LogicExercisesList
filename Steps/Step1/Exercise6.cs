namespace Step1
{
    public static class Exercise6
    {       
        public static void Run()
        {
            // variable declaration
            int num;
            //read the variable
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            //show predecessor
            Console.WriteLine($"The predecessor of {num} is {num - 1}");
            //show the successor
            Console.WriteLine($"The successor of{num} is {num + 1}");
            
        }
    }
}
