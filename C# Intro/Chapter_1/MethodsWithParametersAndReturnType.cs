using System;

class MethodsWithParametersAndReturnType
{
    static void Main()
    {
        string empDetails = getEmployeeDetails(101);
        Console.WriteLine(empDetails);

        string[] empNames = getEmployeeNames();
        foreach(string name in empNames)
        {
            Console.WriteLine(name);
        }

    }

    static string getEmployeeDetails(int number)
    {
        string employeeDetails = $"Employee name is Sandipan and his ID is {number}";
        return employeeDetails;

    }

    static string[] getEmployeeNames()
    {
        string[] names = { "Jhon", "David" };
        return names;
    }
}

