using System;
using System.Collections.Generic;

namespace Step5
{
    public static class Exercise58
    {
        public static void Run()
        {
            int age = 0;
            int totalStudents = 0;
            double middleAge = 0;

            while (true)
            {
                Console.WriteLine("✅Enter the student's age or \n❌ '999' to exit the program");
                age = int.Parse(Console.ReadLine());

                if (age != 999)
                {
                    age += age;
                    totalStudents++;
                }

                middleAge = totalStudents / age;

                Console.WriteLine($"Average age of the group: {middleAge}");
                Console.WriteLine($"Total students: {totalStudents}");
            }
        }

    }
}



