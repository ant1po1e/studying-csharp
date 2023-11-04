using System;

public class IPAddress
{
   // static string[] ipInput = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
   // static string[] address;
   // static bool validLength = false;
   // static bool validZeroes = false;
   // static bool validRange = false;

   // public static void Main(string[] args)
   // {
   //    foreach (string ip in ipInput)
   //    {
   //       address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

   //       ValidateLength();
   //       ValidateZeroes();
   //       ValidateRange();

   //       if (validLength && validZeroes && validRange)
   //       {
   //          Console.WriteLine($"{ip} is a valid IPv4 Address");
   //       }
   //       else
   //       {
   //          Console.WriteLine($"{ip} is an invalid IPv4 Address");
   //       }
   //    }
   // }

   // static void ValidateLength()
   // {
   //    validLength = address.Length == 4;
   // }

   // static void ValidateZeroes()
   // {
   //    foreach (string number in address)
   //    {
   //       if (number.Length > 1 && number.StartsWith("0"))
   //       {
   //          validZeroes = false;
   //          return;
   //       }
   //    }

   //    validZeroes = true;
   // }

   // static void ValidateRange()
   // {
   //    foreach (string number in address)
   //    {
   //       int value = int.Parse(number);

   //       if (value < 0 || value > 255)
   //       {
   //          validRange = false;
   //          return;
   //       }

   //       validRange = true;
   //    }
   // }
}