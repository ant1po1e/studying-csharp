using System;

public class DoWhile
{
   public static void Main(string[] args)
   {
      // Random random = new Random();
      // int current = random.Next(1, 11);
      // int current = 0;

      // do 
      // {
      //    current = random.Next(1, 11);
      //    Console.WriteLine(current);
      // } while (current != 4);

      // while (current >= 2)
      // {
      //    Console.WriteLine(current);
      //    current = random.Next(1, 11);
      // }

      // Console.WriteLine($"Last Number: {current}");


      // Random rand = new Random();
      // int hero = 10;
      // int monster = 10;

      // do 
      // {
      //    int roll = rand.Next(1, 10);
      //    monster -= roll;
      //    Console.Write($"Monster lost {roll} HP and now has {monster} HP.");
      //    Console.ReadKey();

      //    if (monster <=0 ) continue;

      //    roll = rand.Next(1, 10);m rand = new Random();
      // int hero = 10;
      // int monster = 10;

      // do 
      // {
      //    int roll = rand.Next(1, 10);
      //    monster -= roll;
      //    Console.Write($"Monster lost {roll} HP and now has {monster} HP.");
      //    Console.ReadKey();

      //    if (monster <=0 ) continue;

      //    roll = rand.Next(1, 10);
      //    hero -= roll;
      //    Console.Write($"Hero lost {roll} HP and now has {hero} HP.");
      //    Console.ReadKey();
      // } while (hero > 0 && monster > 0);

      // Console.WriteLine(hero
      //    hero -= roll;
      //    Console.Write($"Hero lost {roll} HP and now has {hero} HP.");
      //    Console.ReadKey();
      // } while (hero > 0 && monster > 0);

      // Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


      // string readResult = "";
      // string valueEntered = "";
      // int numValue = 0;
      // bool validNumber = false;

      // Console.WriteLine("Enter an integer value between 5 and 10");

      // do
      // {
      //    readResult = Console.ReadLine();
      //    if (readResult != null)
      //    {
      //       valueEntered = readResult;
      //    }

      //    validNumber = int.TryParse(valueEntered, out numValue);

      //    if (validNumber == true)
      //    {
      //       if (numValue <= 5 || numValue >= 10)
      //       {
      //          validNumber = false;
      //          Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
      //       }
      //    }
      //    else
      //    {
      //       Console.WriteLine("Sorry, you entered an invalid number, please try again");
      //    }
      // } while (validNumber == false);

      // Console.WriteLine($"Your input value ({numValue}) has been accepted.");

      // readResult = Console.ReadLine();


      // string input = "";
      // bool isTrue =  false;

      // Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

      // do
      // {
      //    input = Console.ReadLine();
      //    if (input.Contains("Administrator") || input.Contains("Manager") || input.Contains("User"))
      //    {
      //       Console.WriteLine($"Your input value {input} has been accepted.");
      //       isTrue = true;
      //    } else {
      //       Console.WriteLine($"The role name that you entered, \"{input}\" is not valid.");
      //    }

      // } while (isTrue == false);

   }
}