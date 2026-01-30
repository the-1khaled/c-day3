using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");

        sb.Append(" World");
        sb.Replace("World", "C#");
        sb.Insert(5, ",");
        sb.Remove(6, 3);

        Console.WriteLine(sb.ToString());
    }
}
/*stringBuilder is designed to handle frequent modifications by using a mutable internal buffer, allowing text to be changed in place without creating new objects. This avoids repeated memory allocations and copying that occur with immutable strings, resulting in better performance and lower memory usage when many changes are needed.*/