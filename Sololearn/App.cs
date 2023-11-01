using System;

public class Program
{
   public static void Main(string[] args)
   {
      Welcome();
   }

   static void Welcome()
   {
      Console.WriteLine("Name:");
      string name = Console.ReadLine();
      Console.WriteLine("Welcome, " + name);

   }
}