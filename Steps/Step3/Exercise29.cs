namespace Step3
{
    public static class Exercise29
    {
        public static void Run()
        {
            //Declare the variables
            //employee name
            Console.Write("Enter the employee's name: ");
            string name = Console.ReadLine();
            //current salary
            Console.Write("Enter the employee's salary: ");
            double currentSalary = double.Parse(Console.ReadLine());
            //years of work
            Console.Write("How many years has he worked at the company?  ");
            int yearsWorked = Convert.ToInt32(Console.ReadLine());
            //Declare the variable
            double salaryIncrease;
            //check salary increase
            if (yearsWorked < 3)
            {
                salaryIncrease = 3;
            }
            else if (yearsWorked < 10) 
            {
                salaryIncrease = 12.5;
            }
            else
            {
                salaryIncrease = 20;
            }
            double newSalary = currentSalary * (1 + salaryIncrease / 100);

            //new salary
            Console.WriteLine($"\nThe new salary of {name} is: ${newSalary:F2}");
        }
    }  
}