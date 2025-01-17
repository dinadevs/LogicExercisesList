namespace Step2
{
    public static class Exercise19
    {
        public static void Run()
        {
            // variables declaration
            string name;
            double note1, note2;
            //read variable
            Console.WriteLine("Enter the student's name:");
            name = Console.ReadLine();

            Console.WriteLine("First note:");
            note1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Second note:");
            note2 = double.Parse(Console.ReadLine());
            //calculating notes
            double average = (note1 + note2) / 2;
            //First condition
            if (average > 7.0)
            {
                Console.WriteLine("Approved student!");
            }
            //second condition
            else
            {
                Console.WriteLine("Failed student!");
            }
        }
    }
}
