using System;
internal class CategoriesOfDataTypes
{
    static void Main()
    {
        /*
         Value Data type:
                         Stored directly in stack memory.

                         Hold the actual data.

                         When assigned to another variable, a copy of the value is made.

                         Examples: int, float, char, bool, struct.

                         Fast access, but limited flexibility.


        */
        int a = 10;
        int b = a; // b gets a copy of a

        /*
         Reference Data Types:
                            Stored in heap memory, while the variable holds a reference (pointer) to the data.

                             When assigned to another variable, both variables point to the same object.

                             Examples: class, object, string, array.

                             More flexible, but slower due to heap allocation.
         
         */

        string s1 = "Hello";
        string s2 = s1; // both refer to the same "Hello"

    }
}

