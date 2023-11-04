using System;

public class Parse
{
   public static void Main(string[] args)
   {
      // string value = "117";
      // int result = 0;

      // if (int.TryParse(value, out result))
      // {
      //    Console.WriteLine($"Measurement: {result}");
      // } else
      // {

      // Console.WriteLine("Unable to report the measurement.");
      // }

      // if (result > 0)
      //    Console.WriteLine($"Measurement (w/offset): {69 + result}");


      string[] values = { "12.3", "45", "ABC", "11", "DEF" };

      decimal total = 0m;
      string msg = "";

      foreach (var value in values)
      {
         decimal number;
         if (decimal.TryParse(value, out number))
         {
            total += number;
         } else {
            msg += value;
         }
      }

      Console.WriteLine($"Message: {msg}");
      Console.WriteLine($"Total: {total}");
   }
}