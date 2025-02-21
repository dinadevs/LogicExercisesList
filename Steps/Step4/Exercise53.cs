using System;
using System.Collections.Generic;

namespace Step4
{
    public static class Exercise53
    {
        public static void Run()
        {
            int totalAge = 0;    // total ages
            int totalMen = 0;    //  men
            int totalWomen = 0;  //  women
            int womenOver20 = 0; // women over 20
            int ageMen = 0;      // total ages of men

            //registration of 5 people.
            Console.WriteLine("== Registration for up to 5 people ==");

            for (int i = 0; i < 5; i++)
            {
                //know the gender
                Console.WriteLine("Type F for Female and M for Male:");
                char sex = char.ToUpper(Console.ReadLine()[0]);
                //ages
                Console.Write($"Age of person {i + 1}: ");
                int ageEntered = Convert.ToInt32(Console.ReadLine());

                //The age entered is added
                totalAge += ageEntered;

                //if you are a woman
                if (sex == 'F')
                {
                    totalWomen++; //women accountant
                    if (ageEntered > 20)
                    {
                        womenOver20++; //counter for those with more than 20
                    }
                }
                else if (sex == 'M')
                {
                    {
                        totalMen++; //men accountant
                        totalAge += ageEntered; //add ages men
                    }
                }
                //average age of men
                double averageMen = ageMen / totalMen;
                //average age of the group
                double middleAge = totalAge / sex;
                // result
                Console.WriteLine("\n==== Results ====");
                Console.Write($"How many men were registered {totalMen}: ");
                Console.Write($"How many women were registered {totalWomen}: ");
                Console.Write($"The average age of the group {middleAge}: ");
                Console.Write($"The average age of men{averageMen}: ");
                Console.Write($"How many women are over 20 years old {womenOver20}: ");
            }
        }
    }
}