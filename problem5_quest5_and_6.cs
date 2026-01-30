using System;

class Program
{
    static void Main()
    {
        string str = "Hello";

        Console.WriteLine("Before: " + str.GetHashCode());

        str += " Hi Willy";

        Console.WriteLine("After: " + str.GetHashCode());
    }
}
/*5-Strings are immutable in C# to ensure safety, efficiency, and consistency
 6- StringBuilder addresses the inefficiencies of string concatenation by modifying the same object in memory instead of creating a new string each time, which reduces memory allocations, copying, and garbage collection overhead, especially when many concatenations are performed.
 */