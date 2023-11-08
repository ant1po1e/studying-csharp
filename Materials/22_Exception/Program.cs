using System;

public class Exception
{
   // public static void Main(string[] args)
   // {
   //    string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

   //    string messageText = "";

   //    foreach (string name in names)
   //    {
   //       if (name == "Sophia")
   //          messageText = SophiaMessage();
   //       else if (name == "Andrew")
   //          messageText = AndrewMessage();
   //       else if (name == "AllGreetings")
   //          messageText = SophiaMessage();
   //       messageText = messageText + "\n\r" + AndrewMessage();

   //       Console.WriteLine(messageText + "\n\r");
   //    }

   //    bool pauseCode = true;
   //    while (pauseCode == true) ;

   // }
   // static string SophiaMessage()
   // {
   //    return "Hello, my name is Sophia.";
   // }

   // static string AndrewMessage()
   // {
   //    return "Hi, my name is Andrew. Good to meet you.";
   // }

   // static string readResult = "";
   // static int startIndex = 0;
   // static bool goodEntry = false;

   // static int[] numbers = { 1, 2, 3, 4, 5 };

   // public static void Main(string[] args)
   // {

   //    Console.Clear();
   //    Console.Write("\n\rThe 'numbers' array contains: { ");
   //    foreach (int number in numbers)
   //    {
   //       Console.Write($"{number} ");
   //    }

   //    // To calculate a sum of array elements, 
   //    //  prompt the user for the starting element number.
   //    Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
   //    while (goodEntry == false)
   //    {
   //       readResult = Console.ReadLine();
   //       goodEntry = int.TryParse(readResult, out startIndex);

   //       if (startIndex > 5)
   //       {
   //          goodEntry = false;
   //          Console.WriteLine("\n\rEnter an integer value between 1 and 5");
   //       }
   //    }

   //    // Display the sum and then pause.
   //    Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex)}");

   //    Console.WriteLine("press Enter to exit");
   //    readResult = Console.ReadLine();
   // }

   // // This method returns the sum of elements n through 5
   // static int SumValues(int[] numbers, int n)
   // {
   //    int sum = 0;
   //    for (int i = n; i < numbers.Length; i++)
   //    {
   //       sum += numbers[i];
   //    }
   //    return sum;
   // }

   public static void Main(string[] args)
   {
      string[][] userEnteredValues = new string[][]
   {
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
   };

      try
      {
         Workflow1(userEnteredValues);
         Console.WriteLine("'Workflow1' completed successfully.");

      }
      catch (DivideByZeroException ex)
      {
         Console.WriteLine("An error occurred during 'Workflow1'.");
         Console.WriteLine(ex.Message);
      }
   }

   static void Workflow1(string[][] userEnteredValues)
   {
      foreach (string[] userEntries in userEnteredValues)
      {
         try
         {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
         }
         catch (FormatException ex)
         {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
         }
      }
   }

   static void Process1(String[] userEntries)
   {
      int valueEntered;

      foreach (string userValue in userEntries)
      {
         bool integerFormat = int.TryParse(userValue, out valueEntered);

         if (integerFormat == true)
         {
            if (valueEntered != 0)
            {
               checked
               {
                  int calculatedValue = 4 / valueEntered;
               }
            }
            else
            {
               throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
         }
         else
         {
            throw new FormatException("Invalid data. User input values must be valid integers.");
         }
      }
   }
}