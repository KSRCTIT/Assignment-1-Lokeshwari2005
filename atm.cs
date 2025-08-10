using System;
class Program
{
    static void Main()
    {
        int correctPIN = 1234;
        int attempts = 0;
        bool accessGranted = false;

        while (attempts < 3)
        {
            Console.Write("Enter your PIN: ");
            int enteredPIN = Convert.ToInt32(Console.ReadLine());

            if (enteredPIN == correctPIN)
            {
                Console.WriteLine("Access Granted");
                accessGranted = true;
                break;
            }
            else
            {
                Console.WriteLine("Incorrect PIN. Try again.");
            }

            attempts++;
        }

        if (!accessGranted)
        {
            Console.WriteLine("Card Blocked");
        }
    }
}
