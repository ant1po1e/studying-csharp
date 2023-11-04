using System;

public class StringFormat
{
   public static void Main(string[] args)
   {
      // decimal price = 67.55m;
      // decimal salePrice = 59.99m;

      // string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

      // yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
      // Console.WriteLine(yourDiscount);


      // int invoiceNumber = 1201;
      // decimal productShares = 25.4568m;
      // decimal subtotal = 2750.00m;
      // decimal taxPercentage = .15825m;
      // decimal total = 3185.19m;

      // Console.WriteLine($"Invoice Number: {invoiceNumber}");
      // Console.WriteLine($"   Shares: {productShares:N3} Product");
      // Console.WriteLine($"     Sub Total: {subtotal:C}");
      // Console.WriteLine($"           Tax: {taxPercentage:P2}");
      // Console.WriteLine($"     Total Billed: {total:C}");


      // string paymentId = "769C";
      // string payeeName = "Mr. Stephen Ortega";
      // string paymentAmount = "$5,000.00";

      // var formattedLine = paymentId.PadRight(6);
      // formattedLine += payeeName.PadRight(24);
      // formattedLine += paymentAmount.PadLeft(10);

      // Console.WriteLine("1234567890123456789012345678901234567890");
      // Console.WriteLine(formattedLine);


      // string currentProduct = "Magic Yield";
      // int currentShares = 2975000;
      // decimal currentReturn = 0.1275m;
      // decimal currentProfit = 55000000.0m;
      // string comparisonMessage = "";

      // comparisonMessage = currentProduct.PadRight(20);
      // Console.WriteLine(comparisonMessage);

      // comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
      // Console.WriteLine(comparisonMessage);

      // comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);
      // Console.WriteLine(comparisonMessage);
   }
}