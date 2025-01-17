namespace Step2
{
    public static class Exercise18
    {
        public static void Run()
        {
            // variables declaration
            int birthYear;
            int currentYear = 2025;
            //read variable
            Console.WriteLine("What is the year of birth?");
            birthYear = Convert.ToInt32(Console.ReadLine());
            //calculating age
            int age = currentYear - birthYear;
            //First condition
            if (age >= 18)
            {
                Console.WriteLine("Mandatory voting!");
            }
            //second condition
            else if (age < 16)
            {
                Console.WriteLine("You can't vote!");
            }
            //third condition
            else {
                Console.WriteLine("Optional vote!");
            }
        }
    }
}
