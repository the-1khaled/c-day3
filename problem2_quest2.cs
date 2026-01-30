using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine("Valid integer entered: " + number);
        }
        else
        {
            Console.WriteLine("Error: Invalid integer input.");
        }
    }
}


/*TryParse is recommended over Parse in user-facing applications because it prevents exceptions, safely handles invalid input, and improves application stability by returning false instead of crashing when the user enters incorrect data.*/