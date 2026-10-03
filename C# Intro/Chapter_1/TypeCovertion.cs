using System;



internal class TypeCovertion
{
    static void Main()
    {
        // Implicit Type Convertion --> from a small data type to large data type
        byte smallNumber = 5;
        int largeNumber = smallNumber;

        //Explicit Type Convertion ---> from large data type to small data type ( data might loose)
        int noOfEmployees = 2000;
        byte ConvertingNoOfEmployees = (byte)noOfEmployees;

        // int to string
        int number = 42;
        string ConvertedNumber = number.ToString();

        //string to int
        string age = "23";
        int convertedAge = int.Parse(age);

        /*
        Boxing : Convertion Value → Object
                    Converts a value type → reference type (object).
                    Value is copied from stack → heap.
                    Happens automatically (implicit).

        Unboxing : Convertion Object → Value
                    Converts reference type (object) → value type.
                    Value is copied from heap → stack.
                    Requires explicit cast.
         
        */

        int noOfBottles = 20;
        object obj = noOfBottles;

        object obj1 = 25;
        int noOfComputers = (int)obj1;

    }
}

