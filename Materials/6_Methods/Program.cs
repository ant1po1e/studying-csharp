using System;

public class Methods
{
   public static void Main(string[] args)
   {
      Student();


      // int result = Square(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
      // Console.WriteLine("The result is: " + result);

      // if (result % 2 == 0)
      // {
      //    Console.WriteLine(result + " is an even number.");
      // }
      // else
      // {
      //    Console.WriteLine(result + " is an uneven number.");
      // }


      // Console.Write("Please input a sentence: ");
      // string userInput = Console.ReadLine();
      // int wordCount = WordCount(userInput);
      // Console.WriteLine("The word count is: " + wordCount);
   }

   static void Student()
   {
      Console.Write("How many students are in your class? ");
      int person = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Please input the names of the studens: ");

      string[] students = new string[person];

      for (int i = 0; i < students.Length; i++)
      {
         students[i] = Console.ReadLine();
      }

      Console.WriteLine("-----------------");
      Array.Sort(students);

      for (int i = 0; i < students.Length; i++)
      {
         Console.WriteLine(students[i]);
      }
   }


   static int Square(int number, int number2)
   {
      int result = number * number2;
      return result;
   }


   static int WordCount(string words)
   {
      string[] wordArray = words.Split(' ');
      return wordArray.Length;
   }
}