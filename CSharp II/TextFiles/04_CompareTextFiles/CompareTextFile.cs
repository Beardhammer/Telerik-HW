using System;
using System.IO;

namespace _04_CompareTextFiles
{
    /*Problem 4. Compare text files

    Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
    Assume the files have equal number of lines.
                                                        */
    class CompareTextFile
    {
        static void Main()
        {
            StreamReader firstFileReader = new StreamReader(@"..\..\..\first.txt");
            StreamReader secondFileReader = new StreamReader(@"..\..\..\second.txt");

            int different = 0;
            int equal = 0;

            while (firstFileReader.EndOfStream==false && secondFileReader.EndOfStream==false)   //Not much to describe here either
            {   
                if (firstFileReader.ReadLine() == secondFileReader.ReadLine()) equal++;
                else different++;
            }

            Console.WriteLine("Equal lines: " + equal + "\nDifferent lines: " + different);
        }
    }
}
