using System;
using System.Collections.Generic;

namespace Step5
{
    public static class Exercise58
    {
        public static void Run()
        {
            int totalStudents = 0;
            int totalAge = 0;

            while (true)
            {
                Console.WriteLine("Enter the student's age or \n'999' to exit the program");
                int age = int.Parse(Console.ReadLine());

                if (age != 999) // Infinite loop (exits only with break)
                {
                    break;
                }

                totalAge += age;
                totalStudents++;

                double middleAge = (double)totalAge / totalStudents;

                Console.WriteLine($"Average age of the group: {middleAge}");
                Console.WriteLine($"Total students: {totalStudents}");
            }
        }

    }
}



