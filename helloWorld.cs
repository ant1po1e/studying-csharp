using System;
using System.Collections;
using System.Collections.Generic;


public class Program
{
   public static void Main(string[] args)
   {
      // Console.WriteLine("Hello World!!");


      // string greet = "Hello World!!";
      // Console.WriteLine(greet);


      // string name = "Antipole";
      // int age = 16;
      // bool live = false;
      // string some;

      // if (live == true)
      // {
      //    some = "Yes";
      // }
      // else
      // {
      //    some = "No";
      // }
      // Console.WriteLine("Name: " + name);
      // Console.WriteLine("Age: " + age);
      // Console.WriteLine("Have Life? " + some);



      // int BPS = 80;
      // int BPM = BPS*60;
      // Console.WriteLine(BPM);


      // int x = 10;
      // x++;
      // x--;
      // x--;
      // Console.WriteLine(x);

      // Console.WriteLine(--x);


      // int y = 10;
      // y = y-2;
      // Console.WriteLine(y);


      // int z = 10;
      // z += 5;
      // Console.WriteLine(z);


      // int a = 8;
      // a++;
      // a/=3;
      // Console.WriteLine(a);


      // string nickname;
      // nickname = Console.ReadLine();
      // Console.Write("Welcome, ");
      // Console.WriteLine(nickname);


      // string text = "5";
      // int number = Convert.ToInt32(text);
      // Console.WriteLine(number);


      // Console.WriteLine("Input 1: ");
      // string input1 = Console.ReadLine();
      // Console.WriteLine("Input 2: ");
      // string input2 =  Console.ReadLine();

      // int num1 = Convert.ToInt32(input1);
      // int num2 = Convert.ToInt32(input2);

      // int result = num1 + num2;lolearn: Learn to Code

      // Console.WriteLine("Result: " + result);


      // int x = 0;
      // for (int i = 0; i < 3; i++)
      // {
      //    x += i;
      // }

      // Console.WriteLine(x);


      // for (int i = 1; i < 7; i++)
      // {
      //    if (i == 4)
      //    {
      //       break;
      //    }
      //    Console.WriteLine(i);
      // }


      // int sum = 0;
      // for (int i = 1; i <= 3; i++)
      // {
      //    if (i == 2)
      //    {
      //       continue;
      //    }
      //    sum += 1;
      // }
      // Console.WriteLine(sum);


      // int[] arr = { 8, 2, 6 };

      // int y = 0;

      // foreach (int x in arr)
      // {

      //    y += x / 2;

      // }

      // Console.Write(y);


      // int[,,] a = new int[2, 3, 4];
      // Console.Write(a.Rank);


      // int[] a = { 4, 6, 5, 2 };
      // int x = a[0] + a.Min();
      // Console.Write(x);


      // string s = "SoloLearn is awesome";

      // Console.Write(s.IndexOf('e'));


      // string s = "SoloLearn";
      // int x = s.Length;
      // int y = s.IndexOf("e");
      // Console.Write(x % y);


      // string[] words = {
      //          "home",
      //          "programming",
      //          "victory",
      //          "C#",
      //          "football",
      //          "sport",
      //          "book",
      //          "learn",
      //          "dream",
      //          "fun"
      //       };

      // string letter = Console.ReadLine();

      // int count = 0;

      // foreach (string word in words)
      // {
      //    if (word.Contains(letter))
      //    {
      //       Console.WriteLine(word);
      //       count++;
      //    }
      // }

      // if (count == 0)
      // {
      //    Console.WriteLine("No match");
      // }


      // int[] arr = { 9, 4, 10, 42 };

      // Array.Sort(arr);

      // double x = Math.Sqrt(arr[1]);

      // Console.WriteLine(x);


      // int[] arr = { 8, 5, 4 };

      // Array.Reverse(arr);

      // double x = Math.Pow(arr[0], 2);
      // Console.WriteLine(x);





      // int[] arr = { 2, 5, 3 };
      // int x = 0;
      // try
      // {
      //    x = arr[5];
      // }
      // catch (Exception e)
      // {
      //    x = arr[x];
      // }


      // int x = 0;
      // try
      // {
      //    x /= x;
      //    x += 1;
      // }
      // catch (Exception e)
      // {
      //    x += 3;
      // }
      // finally
      // {
      //    x += 4;
      // }


      // SortedList<string, int> pupil = new SortedList<string, int>();
      // pupil.Add("Bob", 11);
      // pupil.Add("Ann", 9);
      // pupil.Add("Mike", 12);
      // pupil.Remove("Ann");
      // foreach (string s in pupil.Keys)
      //    Console.WriteLine(s + ": " + pupil[s]);


      // BitArray ba1 = new BitArray(4);
      // BitArray ba2 = new BitArray(4);
      // ba1.SetAll(true);
      // ba2.SetAll(false);
      // ba1.Set(2, false);
      // ba2.Set(3, true);
      // Console.Write(ba1.And(ba2).Get(3));


      // Queue<string> q = new Queue<string>();
      // q.Enqueue("A");
      // q.Enqueue("B");
      // q.Enqueue("C");
      // foreach (string s in q)
      //    Console.Write(s + " ");


      // List<int> li = new List<int>();
      // li.Add(59);
      // li.Add(72);
      // li.Add(95);
      // li.RemoveAt(1);
      // for (int x = 0; x < li.Count; x++)
      //    Console.Write(li[x] + " ");


      // List<int> a = new List<int>();
      // a.Add(5);
      // a.Add(2);
      // a.Add(8);
      // a.Reverse();
      // Console.Write(a[1]);


      // BitArray ba1 = new BitArray(4);
      // BitArray ba2 = new BitArray(4);
      // ba1.SetAll(true);
      // ba2.SetAll(false);
      // ba1.Set(2, false);
      // ba2.Set(3, true);
      // Console.Write(ba1.And(ba2).Get(2));


      // Stack<int> s = new Stack<int>();
      // s.Push(4);
      // s.Push(5);
      // s.Push(4);
      // s.Pop();
      // Console.Write(s.Peek());
   }

   // enum Test { a = 2, b, c, d, e };
   // int x = (int)Test.c;
   // Console.WriteLine(x);

   // enum Test { A, B, C = 5, D };
   // static void Main(string[] args)
   // {
   //    int x = (int)Test.D;
   //    Console.WriteLine(x);
   // }
}