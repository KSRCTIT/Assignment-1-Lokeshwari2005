using System;
class Program
{
    static void Main()
    {
        bool isUsernameValid = true;
        bool isPasswordValid = false;

        if (isUsernameValid && isPasswordValid)
        {
            Console.WriteLine("Access Granted");
        }
        else
        {
            Console.WriteLine("Access Denied");
        }

        
        Console.WriteLine("At least one condition is true: " + (isUsernameValid || isPasswordValid));
        Console.WriteLine("Username validity (opposite): " + !isUsernameValid);
        Console.WriteLine("Password validity (opposite): " + !isPasswordValid);
    }
}
