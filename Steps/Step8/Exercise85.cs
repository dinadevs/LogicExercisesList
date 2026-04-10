namespace Step8
{
    public static class Exercise85
    {
        public static void Run()
        {
            Console.WriteLine("=== Step 8 | Exercise 85 ===");

            Double[] wage = new double[5];
            string[] names = new string[5];
            char[] sex = new char[5];
            double biggest5Thousand = 5000.0;

            //employee data  
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Person {i + 1}: ");

                Console.Write("Name: ");
                names[i] = Console.ReadLine();

                Console.Write("Wage: ");
                wage[i] = double.Parse(Console.ReadLine());

                Console.Write("Sex [W/M]: ");
                sex[i] = char.ToUpper(Console.ReadLine()[0]);
            }
            // female employees earning more than $5000
            Console.WriteLine("Female employees who earn more than $5000.0: ");
            for (int i = 0; i < 5; i++)
            {
                if (sex[i] == 'W' && wage[i] > biggest5Thousand)
                {
                    Console.WriteLine($"Name: {names[i]} | sex: {sex[i]}| wage: {wage[i]}");
                }
            }
        }
    }
}
