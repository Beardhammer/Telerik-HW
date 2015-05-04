using System;

namespace _14_PrintASCII
{
    /*  Problem 14.* Print the ASCII Table

    Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

Note: You may need to use for-loops (learn in Internet how).    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = 256;
            Console.OutputEncoding = System.Text.Encoding.Unicode;     //Sets console to Unicode
            for (char ascii=Convert.ToChar(0); ascii<=255; ascii++)    //Loop creates number and then get char assigned to that number
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (ascii>126)  //Code in order to skip unprintable functions
                {
                    if (ascii > 159)   //Code in order to skip unprintable functions
                    {
                        Console.Write("|" + ascii);    //prints char
                    }
                }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else
                {
                    Console.Write("|" + ascii);    //prints char
                }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
            }
            Console.Write("|  ");
        }
    }
}
