using System;

namespace _01_StringsInCSHarp
{
    class DescribingStrings
    {
        static void Main()  //Basically, it's simular to a char array, but it's not quite the same thing as it practically a value type, but technically a reference type
        {
            Console.WriteLine(
                "Straight from MSDN: A string is an object of type String whose value is text.\n" +
                "Internally, the text is stored as a sequential read-only collection of Char objects.\n" +
                "There is no null-terminating character at the end of a C# string; therefore a C# string can contain\n" +
                "any number of embedded null characters ('\0').\n" +
                "The Length property of a string represents the number of Char objects it contains,\nnot the number of Unicode characters.\n" +
                "\nMost important methods of string are string.empty, string.format and string.concat");
        }
    }
}
