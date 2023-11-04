using System;

public class Arrays
{
   public static void Main(string[] args)
   {
      string[] presidents = { "Soekarno", "Soeharto", "Habibie", "Wahid", "Megawati", "Bambang", "Jokowi" };

      for (int i = 0; i < presidents.Length; i++)
      {
         int num = i + 1;
         Console.WriteLine(num + ". " + presidents[i]);
      }


      // string[] artists = new string[4];

      // Console.WriteLine("Type in four artists you like: ");
      // for (int i = 0; i < artists.Length; i++)
      // {
      //    artists[i] = Console.ReadLine();
      // }

      // Console.WriteLine("\nHere they are alphabeticallly: ");
      // Array.Sort(artists);

      // for (int i = 0; i < artists.Length; i++)
      // {
      //    Console.WriteLine(artists[i]);
      // }
   }
}