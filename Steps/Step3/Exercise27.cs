namespace Step3
{
    public static class Exercise27
    {
        public static void Run()
        {
            Console.WriteLine("Enter the first grade:");
            int firstGrade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second grade:");
            int secondGrade = Convert.ToInt32(Console.ReadLine());

            int average = (firstGrade + secondGrade) / 2;

            if (average <= 4.9)
            {
                Console.WriteLine($"Average: {average:F1} Failed");
            }
            else if (average >= 5.0 && average <= 6.9)
            {
                Console.WriteLine($"Average: {average:F1} Recovery");
            }
            else
            {
                Console.WriteLine($"Average: {average:F1} Approved");
            }
        }
    }
}