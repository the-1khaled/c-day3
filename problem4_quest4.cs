using System;

class MyClass
{
    public int Value;
}

class Program
{
    static void Main()
    {
        MyClass obj1 = new MyClass();
        obj1.Value = 10;

        MyClass obj2 = obj1;

        obj1.Value = 50;

        Console.WriteLine(obj2.Value);
    }
}
/*Reference equality in .NET determines whether two variables point to the exact same object in memory, not just whether their contents are equal. It is important for understanding how changes to one reference affect another and for correctly comparing objects in memory-sensitive operations.*/