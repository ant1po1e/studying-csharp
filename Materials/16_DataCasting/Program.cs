using System;

public class DataCast
{
   public static void Main(string[] args)
   {
      // int first = 2;
      // string second = "4";
      // string result = first + second;
      // Console.WriteLine(result);


      // decimal myDecimal = 3.14m;
      // Console.WriteLine($"Decimal: {myDecimal}");

      // int myInt = (int)myDecimal;
      // Console.WriteLine($"Integer: {myInt}");


      // decimal myDecimal = 1.23456789m;
      // float myFloat = (float)myDecimal;

      // Console.WriteLine($"Decimal: {myDecimal}");
      // Console.WriteLine($"Float: {myFloat}");


      // int first = 5;
      // int second = 7;
      // string msg = first.ToString() + second.ToString();
      // Console.WriteLine(msg);

      string first = "5";
      string second = "7";
      int sum = int.Parse(first) + int.Parse(second); //int Convert.ToInt32(first) + Convert.ToInt32(second);
      Console.WriteLine(sum);
   }
}