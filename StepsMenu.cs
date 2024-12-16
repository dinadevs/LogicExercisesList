using System;

class StepsMenu
{
    public static void Show(string step)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"=== Step {step} ===");
            Console.Write("Send the exercise number or 0 to return: ");

            string option = Console.ReadLine();
            if(option != "0") {
                RunExercise(step, option);
            } else {
                return;
            }
        }
    }

    private static void RunExercise(string step, string exercise)
    {
        string className = $"Step{step}.Exercise{exercise}"; 
        Type classType = Type.GetType(className);
        if (classType != null)
        {
            var method = classType.GetMethod("Run");
            method?.Invoke(null, null);
        }
        else
        {
            Console.WriteLine("Exercise not found ~_~");
        }

        Console.WriteLine("\nPress any key to return to menu.");
        Console.ReadKey();
    }
}