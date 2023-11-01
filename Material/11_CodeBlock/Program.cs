using System;

public class CodeBlock
{
   public static void Main(string[] args)
   {
      // bool flag = true;
      // int value = 0;

      // if (!flag)
      // {
      //    value = 10;
      //    Console.WriteLine("Inside of code block: " + value);
      // }
      // Console.WriteLine("Outside of code block: " + value);


      // string name = "steve";

      // if (name == "bob")
      //    Console.WriteLine("Found Bob");
      // else if (name == "steve")
      //    Console.WriteLine("Found Steve");
      // else
      //    Console.WriteLine("Found Chuck");


      // int[] numbers = { 4, 8, 15, 16, 23, 1 };
      // bool found = false;
      // int total = 0;

      // foreach (int number in numbers)
      // {
      //    total += number;

      //    if (number == 1)
      //    {
      //       found = true;

      //    }

      // }

      // if (found)
      // {
      //    Console.WriteLine("Set contains 1");

      // }

      // Console.WriteLine($"Total: {total}");


      int firstInteger = 5; 

      if (firstInteger > 0)
      {
         int secondInteger = 8; 
         firstInteger += secondInteger; 
      }

      Console.WriteLine("The value of the first integer is: " + firstInteger);
   }
}