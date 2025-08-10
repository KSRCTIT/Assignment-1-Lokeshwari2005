using System;
class Program
{
    static void Main()
    {
        int playerA = 20;
        int playerB = 15;

        Console.WriteLine("Player A scored more than Player B: " + (playerA > playerB));
        Console.WriteLine("Scores are equal: " + (playerA == playerB));
        Console.WriteLine("Player A failed to beat Player B: " + (playerA <= playerB));
        Console.WriteLine("Player B failed to beat Player A: " + (playerB <= playerA));
    }
}
