using System;
class Program
{
    static void Main()
    {
        int a = 10;
        int b = 5;

        int totalApples = a + b;             
        int pencilDifference = a - b;        
        int totalPages = a * b;               
        int chocolatesPerKid = a / b;         
        int leftoverCandies = a % b;          

        Console.WriteLine("Total apples: " + totalApples);
        Console.WriteLine("Difference of pencils: " + pencilDifference);
        Console.WriteLine("Total pages when " + a + " pages are copied " + b + " times: " + totalPages);
        Console.WriteLine("Chocolates per kid: " + chocolatesPerKid);
        Console.WriteLine("Leftover candies: " + leftoverCandies);
    }
}
