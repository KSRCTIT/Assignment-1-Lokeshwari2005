using System;
class Program
{
    static void Main()
    {
        double price = 1000.0;
        double discount = 10.0;
        double discountAmount = (price * discount) / 100.0;

        double finalPrice = price - discountAmount;

        Console.WriteLine("Original Price: " + price);
        Console.WriteLine("Discount: " + discount + "%");
        Console.WriteLine("Final Price: " + finalPrice);
    }
}
