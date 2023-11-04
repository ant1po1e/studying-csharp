using System;

public class ModifyString
{
   public static void Main(string[] args)
   {
      // string message = "What is the value <span>between the tags</span>?";

      // const string openSpan = "<span>";
      // const string closeSpan = "</span>";

      // int openingPosition = message.IndexOf(openSpan);
      // int closingPosition = message.IndexOf(closeSpan);

      // openingPosition += openSpan.Length;
      // int length = closingPosition - openingPosition;
      // Console.WriteLine(message.Substring(openingPosition, length));


      // string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
      // char[] openSymbols = { '[', '{', '(' };

      // int closingPosition = 0;

      // while (true)
      // {
      //    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

      //    if (openingPosition == -1) break;

      //    string currentSymbol = message.Substring(openingPosition, 1);
      //    char matchingSymbol = ' ';

      //    switch (currentSymbol)
      //    {
      //       case "[":
      //          matchingSymbol = ']';
      //          break;
      //       case "{":
      //          matchingSymbol = '}';
      //          break;
      //       case "(":
      //          matchingSymbol = ')';
      //          break;
      //    }

      //    openingPosition += 1;
      //    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

      //    int length = closingPosition - openingPosition;
      //    Console.WriteLine(message.Substring(openingPosition, length));
      // }


      // string message = "This--is--ex-amp-le--da-ta";
      // message = message.Replace("--", " ");
      // message = message.Replace("-", "");
      // Console.WriteLine(message);


      const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

      string quantity = "";
      string output = "";

      int quantityStart = input.IndexOf("<span>");
      int quantityEnd = input.IndexOf("</span>");
      quantityStart += "<span>".Length; 
      int quantityLength = quantityEnd - quantityStart;
      quantity = input.Substring(quantityStart, quantityLength); 
      quantity = $"Quantity: {quantity}";

      output = input.Replace("&trade;", "&reg;");

      int divStart = input.IndexOf("<div>");
      int divLength = "<div>".Length;
      output = output.Remove(divStart, divLength);

      int divCloseStart = output.IndexOf("</div>");
      int divCloseLength = "</div>".Length;
      output = output.Remove(divCloseStart, divCloseLength);
      output = $"Output: {output}";

      Console.WriteLine(quantity);
      Console.WriteLine(output);
   }
}