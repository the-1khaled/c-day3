using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        try
        {
            // Using int.Parse
            int number1 = int.Parse(input);
            Console.WriteLine("int.Parse result: " + number1);

            // Using Convert.ToInt32
            int number2 = Convert.ToInt32(input);
            Console.WriteLine("Convert.ToInt32 result: " + number2);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Input is not in a correct numeric format.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The number is too large or too small for an int.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }
}
/*
`int.Parse` throws an exception when the input is `null`, while `Convert.ToInt32` converts a `null` input to `0`.
*/