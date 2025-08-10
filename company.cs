using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsValidName(string name)
    {
       
        return Regex.IsMatch(name, @"^[A-Za-z\s]+$");
    }

    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        if (IsValidName(name))
        {
            Console.WriteLine("Valid name. Proceed with ID card printing.");
        }
        else
        {
            Console.WriteLine("Invalid name. Name should not contain digits or special characters.");
        }
    }
}
