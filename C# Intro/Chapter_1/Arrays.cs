using System;

internal class Arrays
{
    static void Main()
    {
        int[] numbersGroup = new int[2];
        numbersGroup[0] = 100;
        numbersGroup[1] = 200;
        Console.WriteLine(string.Join(",",numbersGroup));
        Console.WriteLine($"Number Group is {numbersGroup}");


        int[] numbersGroup2 = new int[] { 100, 200 };

        //============== ForEach ==================

        //foreach(datatype | var variableName in collectionName){
        //    Code
        //}

        int[] currencyNotes = { 5, 10, 20, 50, 100, 200, 500 };

        foreach(int curr in currencyNotes)
        {
            int add = 5;
            int UpdatedCurrency = curr + add;
            Console.WriteLine($"Printing Every currency : {UpdatedCurrency}");
        }

        string[] books = { "Mathematics", "Physics-I", "Physics-II", "Chemistry" };
        foreach(var book in books)
        {
            Console.WriteLine($"Name of the Books are : {book}");
        }





    }
}

