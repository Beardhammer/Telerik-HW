using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _06_SaveSortedNames
{
    /*Problem 6. Save sorted names

    Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

Example:
input.txt 	output.txt
Ivan
Peter
Maria
George 	George
Ivan
Maria
Peter                                                       */
    class SaveSortedNames
    {
        static void Main()
        {
            StreamReader fileReader = new StreamReader(@"..\..\..\Names.txt");
            StreamWriter resultPrinter = new StreamWriter(@"..\..\..\SortedNames.txt");

            List<string> names=new List<string>();
            using (fileReader)
            {
                names = fileReader.ReadToEnd().Split(new[] { ' ','\r','\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                //First we split the text file by empty spaces, newlines, and anything else we need
            }
            using (resultPrinter)
            {
                names.Sort();
                foreach (string name in names)
                {
                    resultPrinter.WriteLine(name);
                    //Then we sort it and print it element by element on new line
                }
            }
        }
    }
}
