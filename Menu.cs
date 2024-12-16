using System;

class Menu
{
    public static void Show()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Logic Exercises List ===");
            Console.WriteLine("1. Step 1");
            Console.WriteLine("2. Step 2");
            Console.WriteLine("3. Step 3");
            Console.WriteLine("4. Step 4");
            Console.WriteLine("5. Step 5");
            Console.WriteLine("6. Step 6");
            Console.WriteLine("7. Step 7");
            Console.WriteLine("8. Step 8");
            Console.WriteLine("9. Step 9");
            Console.WriteLine("10. Step 10");
            Console.WriteLine("0. Exit");
            Console.Write("Select a step: ");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    StepsMenu.Show(option);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid! Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}