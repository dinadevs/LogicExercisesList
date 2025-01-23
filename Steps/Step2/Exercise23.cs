using System.Diagnostics.CodeAnalysis;

namespace Step2
{
    public static class Exercise23
    {
        public static void Run()
        {
            // variables declaration
            double wonDisc = 13, menDisc = 5;

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Type F for Female and M for Male:");
            char sex = char.ToUpper(Console.ReadLine()[0]);
            //check the sex
            if (sex == 'F' || sex == 'M')
            {   //account value
                Console.WriteLine("Enter your account amount:");
                double proctValue = double.Parse(Console.ReadLine());
                //check the discount
                double discountRate = (sex == 'F') ? wonDisc : menDisc;
                //discounted final price
                double finalValue = proctValue * (1 - discountRate / 100);
                
                Console.WriteLine($"Congratulations, you got a {(sex == 'M' ? "5%" : "13%")} discount!");
                Console.WriteLine($"Amount to be paid: {finalValue:C}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please type 'F' for Female or 'M' for Male.");
            }
        }
    }
}
