using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int input1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int input2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Sum is " + (input1 + input2));

        Console.WriteLine(string.Format("Sum is {0}", input1 + input2));

        Console.WriteLine($"Sum is {input1 + input2}");
    }
}
/* String interpolationis the most commonly used string formatting method because it is more readable, easier to write, and less error-prone than concatenation or string.Format, especially when working with multiple variables./*