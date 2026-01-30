using System;

class Program
{
    static void Main()
    {
        object x;

        x = 5;
        Console.WriteLine(x.GetHashCode());

        x = "Hi";
        Console.WriteLine(x.GetHashCode());

        x = 2.5;
        Console.WriteLine(x.GetHashCode());
    }
}

/*The real purpose of GetHashCode() is to generate a hash value that helps objects be quickly located and compared in hash-based collections such as Dictionary, HashSet, and Hashtable, improving lookup performance.*/