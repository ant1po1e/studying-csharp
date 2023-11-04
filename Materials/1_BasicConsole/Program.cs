using System;

public class BasicConsole
{
   static void Main(string[] args)
   {
      Console.WriteLine("A proud knight named...");
      Console.ReadLine();

      Console.WriteLine("... walked into a bar. At the counter he met a...");
      Console.ReadLine();

      Console.WriteLine("... who asked him what he wanted to drink?");
      Console.ReadLine();

      Console.WriteLine("... shouted the knight! The bartender kick him quickly.");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("But it was to late... the Dragon ate them both");
   }
}

