namespace Step1
{
    public static class Exercise3
    {       
        public static void Run()
        {
            // variables declaration
            string name;
            double wage;
            // read name and wage
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the wage: ");
            wage = double.Parse(Console.ReadLine());
            // show a message
            Console.WriteLine($"Employee name: {name}");
            Console.WriteLine($"Wage: R${wage}");
            Console.WriteLine($"The employee {name} has a wage of R${wage} in June");
        }
    }
}
