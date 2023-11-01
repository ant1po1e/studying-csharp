using System;

public class Foreach
{
   public static void Main(string[] args)
   {
      string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

      Console.WriteLine("Starts With B");
      foreach (string orderID in orderIDs)
      {
         if (orderID.StartsWith("B"))
         {
            Console.WriteLine(orderID);
         }
      }

      Console.WriteLine("");

      Console.WriteLine("Starts With C");
      foreach (string orderID in orderIDs)
      {
         if (orderID.StartsWith("C"))
         {
            Console.WriteLine(orderID);
         }
      }
   }
}