using System;

public class Loops
{
   public static void Main(string[] args)
   {
      // Console.Write("How many loop do you want to see? ");
      // int num = Convert.ToInt32(Console.ReadLine());

      // for (int i = 1; i <= num; i++)
      // {
      //    double result = Math.Pow(2, i);
      //    Console.WriteLine(result);
      // }


      Random randNum = new Random();
      Random randNum2 = new Random();

      int roll = 0;
      int roll2 = 1;
      int attempts = 0;

      Console.WriteLine("Press ENTER to roll the dice until you get 1.");

      while (roll != roll2)
      {
         Console.ReadKey();
         roll = randNum.Next(1, 6);
         Console.WriteLine("Roll 1: " + roll);

         roll2 = randNum2.Next(1, 6);
         Console.WriteLine("Roll 2: " + roll2);

         Console.WriteLine("");
         attempts++;
      }

      Console.WriteLine("It took you " + attempts + " attempts to roll two of kind.");
   }
}