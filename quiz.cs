using System;
class Program
{
    static void Main()
    {
        int score = 50;
        Console.WriteLine("Starting score: " + score);

        score += 10;
        Console.WriteLine("After correct answer (+10): " + score);

        score -= 5;
        Console.WriteLine("After wrong answer (-5): " + score);

        score *= 2;
        Console.WriteLine("After bonus round (x2): " + score);

        score /= 5;
        Console.WriteLine("After penalty (/5): " + score);
    }
}
