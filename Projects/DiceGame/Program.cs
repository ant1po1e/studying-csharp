using System;

public class DiceGame
{
   static Random random = new Random();
   public static void Main(string[] args)
   {

      Console.WriteLine("Would you like to play? (Y/N)");
      if (ShouldPlay())
      {
         PlayGame();
      }
   }

   static bool ShouldPlay()
   {
      string response = Console.ReadLine();
      return response.ToLower().Equals("y");
   }

   static void PlayGame()
   {
      var play = true;

      while (play)
      {
         var target = GetTarget();
         var roll = RollDice();

         Console.WriteLine($"Roll a number greater than {target} to win!");
         Console.WriteLine($"You rolled a {roll}");
         Console.WriteLine(WinOrLose(roll, target));
         Console.WriteLine("\nPlay again? (Y/N)");

         play = ShouldPlay();
      }
   }

   static int GetTarget()
   {
      return random.Next(1, 6);
   }

   static int RollDice()
   {
      return random.Next(1, 7);
   }

   static string WinOrLose(int roll, int target)
   {
      if (roll > target)
      {
         return "You win!";
      }
      return "You lose!";
   }
}