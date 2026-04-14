using System.IO.Pipelines;

namespace Step10
{
    public static class Exercise100
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 10 | Exercise 100 ===");

            {   //notes
                Console.Write("Enter the first note: ");
                int note1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second note: ");
                int note2 = int.Parse(Console.ReadLine());
                // Calls the Average function to calculate the average
                double result = Average(note1, note2);
                // Calls the Situation function passing the average as a parameter.
                string situation = Situation(result);

                Console.WriteLine($"The average is: {result}");
                Console.WriteLine($"Situation: {situation}");

            }// Function that calculates the average grade
            static double Average(int note1, int note2)
            {
                double avg = (note1 + note2) / 2.0;
                return avg; // Returns the average value
            }// Function that defines the student's situation
            static string Situation(double avg)
            {
                if (avg >= 7)
                {
                    return "APROVADO";
                }
                else if (avg >= 5)
                {
                    return "RECUPERAÇÃO";
                }
                else
                {
                    return "REPROVADO";
                }
            }
        }
    }
}