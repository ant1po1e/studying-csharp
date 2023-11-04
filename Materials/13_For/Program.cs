using System;

public class For
{
   public static void Main(string[] args)
   {
      for (int i = 1; i <= 100; i++)
      {
         if (i % 3 == 0 && i % 5 == 0) Console.WriteLine($"{i}\tFizzBuzz");
         else if (i % 3 == 0) Console.WriteLine($"{i}\tFizz");
         else if (i % 5 == 0) Console.WriteLine($"{i}\tBuzz");
         else Console.WriteLine($"{i}");
      }
   }
}