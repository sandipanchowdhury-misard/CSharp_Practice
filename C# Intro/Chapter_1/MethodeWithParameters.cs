using System;


class MethodeWithParameters
{
    static void Main()
    {
        Method1(100);
        Method2("Sandipan");
    }

    static void Method1( int number)
    {
        Console.WriteLine($"Method1 is called and number is {number}");
    }

    static void Method2(string name)
    {
        Console.WriteLine($"Method2 is called and the name is {name}");
    }

}

