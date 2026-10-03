using System;


internal class MethodsWithReturnType
{
    static void Main()
    {
        string emp = Method1();
        int id = Method2();
        Console.WriteLine($"Employee name : {emp}");
        Console.WriteLine($"Id : {id}");
    }

    static string Method1()
    {
        string employeeName = "Jhon";
        return employeeName;
    }

    static int Method2()
    {
        int empId = 101;
        return empId;
    }
}
