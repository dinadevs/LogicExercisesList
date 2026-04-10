using System.Diagnostics.CodeAnalysis;

namespace Step8
{
    public static class Exercise82
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 8 | Exercise 82 ===");

            int[] note = new int[10];
            int sum = 0;
            int aboveAverage = 6;
            int highestGrade = 0;

            Console.WriteLine("\nHighest grade:");
            // Read grades 
            for(int i = 0; i < note.Length; i++)
            {
                Console.WriteLine($"Enter the note {i + 1}° student: ");
                note[i] = Convert.ToInt32(Console.ReadLine());

                if(note[i] > highestGrade)
                {
                    highestGrade = note[i];
                }
            }

            // Calculate average
            double average = (double)sum / note.Length;
            Console.WriteLine($"\nclass average: {average}");
                      
            // Students above average
            for(int i = 0; i < note.Length; i++)
            {
                if(note[1] >= average)
                {
                    aboveAverage++;
                }
            }
            Console.WriteLine($"\nclass average: {aboveAverage}");
            Console.WriteLine($"Highest grade: {highestGrade}");
            // highest grades
            Console.Write("Positions of the highest grade: ");
            for(int i = 0; i < note.Length; i++)
            {
                if(note[i] == highestGrade)
                {
                    Console.Write($"{i +1} ");
                }
            }
        }
    }
}
