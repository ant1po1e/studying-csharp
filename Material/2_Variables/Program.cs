using System;

public class Variables
{
   static void Main(string[] args)
   {
      double num1;
      double num2;
      double num3;

      Console.Write("Input a number: ");
      num1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Input a second number: ");
      num2 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Input a third number: ");
      num3 = Convert.ToDouble(Console.ReadLine());

      double result = (num1 + num2 + num3) / 3;

      Console.WriteLine("The average of these number is: " + result);
   }
}