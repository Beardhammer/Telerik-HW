using System;
using System.IO;

namespace _01_OddLines
{
    /*Problem 1. Odd lines

    Write a program that reads a text file and prints on the console its odd lines.
                                                                                                */
    class OddLinesReader
    {
        static void Main()
        {
            StreamReader fileReader=new StreamReader(@"..\..\..\first.txt");

            for (int i = 1; fileReader.EndOfStream==false; i++) //Basically, we read the whole document, but only print a line when i is an odd line
            {
                Console.WriteLine(fileReader.ReadLine());   //First, we print a line, then
                fileReader.ReadLine();                      //We read the next one, effectivelly consuming it, but we don't print it
            }
            fileReader.Close();
        }
    }
}
