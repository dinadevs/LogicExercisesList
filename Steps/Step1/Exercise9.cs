namespace Step1
{
    public static class Exercise9
    {       
        public static void Run()
        {
            // variable declaration
            double money;
            //read the variable
            Console.WriteLine("Enter how much money in R$: ");
            money = double.Parse(Console.ReadLine());
            //show how much the dollar is
            Console.WriteLine($"You have R${money}. The current exchange rate is US$1.00 = R$3.45");
            //show how many dollars it can buy.
            Console.WriteLine($"With R${money}, you can buy approximately US${money / 3.45:F2}.");
                     
        }
    }
}
