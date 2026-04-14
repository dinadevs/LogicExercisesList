namespace Step10
{
    public static class Exercise96
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 10 | Exercise 96 ===");

            {   
                Console.Write("Enter the first note: ");
                int note1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second note: ");
                int note2 = int.Parse(Console.ReadLine());
                // Calls the 'average' function to calculate the average
                double result = average(note1, note2);

                Console.WriteLine($"The average is: {result}");
            }// Function that calculates the average and displays the situation
            static double average(int note1, int note2) 
            {
                double avg = (note1 + note2) / 2.0;

                if(avg >= 7) 
                {
                    Console.Write("Approved student!");
                }
                else if (avg >= 5) 
                {
                    Console.Write("Student in recovery!");
                }
                else 
                {
                    Console.Write("Failed student!");
                }
                return avg;
            }
        }
    }
}