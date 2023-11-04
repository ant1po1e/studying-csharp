using System;

public class ArrayOperation
{
   public static void Main(string[] args)
   {
      ////////// Sort & Reverse
      // string[] pallets = { "B14", "A11", "B12", "A13" };

      // Console.Write("Sorting...");
      // Console.ReadKey();

      // Array.Sort(pallets);
      // foreach (var pallet in pallets)
      // {
      //    Console.WriteLine($"-- {pallet}");
      // }

      // Console.WriteLine("");
      // Console.Write("Reversing...");
      // Console.ReadKey();

      // Array.Reverse(pallets);
      // foreach (var pallet in pallets)
      // {
      //    Console.WriteLine($"-- {pallet}");
      // }


      ////////// Clear & Resize
      // string[] pallets = { "B14", "A11", "B12", "A13" };
      // Console.WriteLine("");

      // Array.Clear(pallets, 0, 2);
      // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
      // foreach (var pallet in pallets)
      // {
      //    Console.WriteLine($"-- {pallet}");
      // }

      // Console.WriteLine("");
      // Array.Resize(ref pallets, 6);
      // Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

      // pallets[4] = "C01";
      // pallets[5] = "C02";

      // foreach (var pallet in pallets)
      // {
      //    Console.WriteLine($"-- {pallet}");
      // }

      // Console.WriteLine("");
      // Array.Resize(ref pallets, 3);
      // Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

      // foreach (var pallet in pallets)
      // {
      //    Console.WriteLine($"-- {pallet}");
      // }


      ////////// Split & Join
      // string value = "abc123";
      // char[] valueArray = value.ToCharArray();
      // Array.Reverse(valueArray);
      // // string result = new string(valueArray);
      // string result = String.Join(",", valueArray);
      // Console.WriteLine(result);

      // string[] items = result.Split(',');
      // foreach (string item in items)
      // {
      //    Console.WriteLine(item);
      // }string pangram = "The quick brown fox jumps over the lazy dog";


      // string pangram = "The quick brown fox jumps over the lazy dog";
      // string[] msg = pangram.Split(' ');
      // string[] newMsg = new string[msg.Length];

      // for (int i = 0; i < msg.Length; i++)
      // {
      //    char[] letters = msg[i].ToCharArray();
      //    Array.Reverse(letters);
      //    newMsg[i] = new string(letters);
      // }

      // string result = string.Join(" ", newMsg);
      // Console.WriteLine(result);

      string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
      string[] items = orderStream.Split(',');
      Array.Sort(items);

      foreach (var item in items)
      {
         if (item.Length == 4)
            Console.WriteLine(item);
         else
            Console.WriteLine(item + "\t- Error");
      }
   }
}
