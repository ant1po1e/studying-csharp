using System;

public class FortuneTeller
{
   static Random random = new Random();
   static int luck = random.Next(100);

   static string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
   static string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
   static string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
   static string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

   public static void Main(string[] args)
   {
      luck = random.Next(100);
      TellFortune();
   }

   static void TellFortune()
   {
      Console.WriteLine("A fortune teller whispers the following words: ");
      string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));

      for (int i = 0; i < 4; i++)
      {
         Console.Write($"{text[i]} {fortune[i]} ");
      }
   }
}