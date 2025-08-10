using System;
class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter age of person " + i + ": ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Eligible to Vote");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }

            Console.WriteLine(); 
        }
    }
}
