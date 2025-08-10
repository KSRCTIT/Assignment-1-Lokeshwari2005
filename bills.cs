using System;
class Program
{
    static void Main()
    {
        char choice;
        do
        {
            Console.Write("Enter a number to print its multiplication table: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication Table of {num}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }

            Console.Write("Do you want to try another number? (Y/N): ");
            choice = Convert.ToChar(Console.ReadLine().ToUpper());
        }
        while (choice == 'Y');

        Console.WriteLine("\n--- Electricity Bill Calculation ---");
        Console.Write("Enter units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());
        double bill = 0;

        if (units <= 100)
        {
            bill = units * 2;
        }
        else if (units <= 200)
        {
            bill = (100 * 2) + ((units - 100) * 3);
        }
        else
        {
            bill = (100 * 2) + (100 * 3) + ((units - 200) * 5);
        }

        Console.WriteLine($"Total Electricity Bill: Rs:{bill}");
    }
}
