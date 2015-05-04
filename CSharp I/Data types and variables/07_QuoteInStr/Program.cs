using System;

namespace _07_QuoteInStr    //07-Not much to look at. Just prints some strings with and without quotation marks
{
    /*  Problem 7. Quotes in Strings

    Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
    Do the above in two different ways - with and without using quoted strings.
    Print the variables to ensure that their value was correctly defined.   */

    class Program   //Not much to see her, eh? I couldn't come up with anything to add wo this program :(
    {
        static void Main(string[] args)
        {
            string withQMarks="The \"use\" of quotations causes difficulties.";
            string withOutQMarks = "The use of quotations causes difficulties.";
            Console.WriteLine("\n" + withQMarks + "\n" + withOutQMarks);    //Prints both strings on different lines
        }
    }
}
