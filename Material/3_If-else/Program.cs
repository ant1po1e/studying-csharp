using System;

public class IfElse
{
   public static void Main(string[] args)
   {
      Console.Write("What's 8 * 7? ");
      int case1 = Convert.ToInt32(Console.ReadLine());
      if (case1 == 56)
      {
         Console.WriteLine("Correct!");
      }
      else
      {
         Console.WriteLine("Wrong!");
         Environment.Exit(1);
      }

      Console.Write("What's 5 + 11 * 9 / 3? ");
      int case2 = Convert.ToInt32(Console.ReadLine());
      if (case2 == 38)
      {
         Console.WriteLine("Correct!");
      }
      else
      {
         Console.WriteLine("Wrong!");
         Environment.Exit(1);
      }


      // int daysUntilExpiration = Convert.ToInt32(Console.ReadLine());
      // int discountPercentage = 0;

      // if (daysUntilExpiration <= 10 && daysUntilExpiration > 5)
      // {
      //    Console.WriteLine("Your subscription will expire soon. Renew now!");
      // }
      // else if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
      // {
      //    discountPercentage = 10;
      //    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
      //    Console.WriteLine($"Renew now and save {discountPercentage}%.");
      // }
      // else if (daysUntilExpiration == 1)
      // {
      //    discountPercentage = 20;
      //    Console.WriteLine("Your subscription expires within a day!");
      //    Console.WriteLine($"Renew now and save {discountPercentage}%.");
      // }
      // else
      // {
      //    Console.WriteLine("Your subscription has expired.");
      // }
   }
}