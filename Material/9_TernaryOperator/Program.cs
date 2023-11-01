using System;

public class Ternary
{
   public static void Main(string[] args)
   {
      Random coin = new Random();
      int flip = coin.Next(0, 2);

      Console.WriteLine("Press ENTER to flip the coin.");
      Console.ReadKey();
      Console.WriteLine((flip == 0) ? "heads" : "tails");

   }
}