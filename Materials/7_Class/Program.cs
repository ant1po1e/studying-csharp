using System;

public class Class
{
   class Hero
   {
      public string name;
      public string type;
      public float energy;
      public float exp;
   }

   public static void Main(string[] args)
   {
      Hero person = new Hero();

      Console.Write("Input the hero name: ");
      person.name = Console.ReadLine();
      Console.Write("Input the hero type: ");
      person.type = Console.ReadLine();
      Console.Write("Input the hero energy: ");
      person.energy = Convert.ToInt32(Console.ReadLine());
      Console.Write("Input the hero experience: ");
      person.exp = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("--------------");
      Console.WriteLine("Hero name: " + person.name + "\nHero type: " + person.type + "\nHero energy: " + person.energy + "\nHero experience: " + person.exp);
   }
}