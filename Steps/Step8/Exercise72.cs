namespace Step8
{
  public static class Exercise72
  {
    public static void Run()
    {
      Console.WriteLine("=== Step 8 | Exercise 72 ===");

      // Create array 
      int[] num = new int[10];
      const int INTERVALO_NUMBER = 5;

      for (int i = 0; i < num.Length; i++)
      {
        num[i] = (i + 1) * INTERVALO_NUMBER; //define interval
      }
      
      for (int i = 0; i < num.Length; i++)
      {
        Console.Write($"{num[i]} ");
      }
    }
  }
}
