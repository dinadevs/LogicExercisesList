namespace Step2
{
    public static class Exercise20
    {
        public static void Run()
        {
            // variables declaration
            int num;

            Console.WriteLine("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            //First condition. Check if the number is even
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num}  it's even");
            }
            //second condition
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }
    }
}
