using System;

public class Boolean
{
   public static void Main(string[] args)
   {
      Console.WriteLine("Please input Permission Type. (Admin|Manager)");
      string permission = Console.ReadLine();
      Console.WriteLine("Please input level");
      int level = Convert.ToInt32(Console.ReadLine());

      if (permission.Contains("Admin"))
      {
         if (level > 55)
         {
            Console.WriteLine("Welcome, Super Admin user.");
         }
         else
         {
            Console.WriteLine("Welcome, Admin user.");
         }
      }
      else if (permission.Contains("Manager"))
      {
         if (level >= 20)
         {
            Console.WriteLine("Contact an Admin for access.");
         }
         else
         {
            Console.WriteLine("You do not have sufficient privileges.");
         }
      }
      else
      {
         Console.WriteLine("You do not have sufficient privileges.");
      }
   }
}