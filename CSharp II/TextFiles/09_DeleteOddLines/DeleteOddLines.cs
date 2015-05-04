using System;
using System.IO;
using System.Text;

namespace _09_DeleteOddLines
{
    /*Problem 9. Delete odd lines

    Write a program that deletes from given text file all odd lines.
    The result should be in the same file.
                                                            */
    class DeleteOddLines
    {
        static void Main()
        {
            try
            {
                StringBuilder fileBuilder = new StringBuilder();
                StreamReader readFile = new StreamReader(@"..\..\..\OddLineDeler.txt");
                using (readFile)
                {
                    while (readFile.EndOfStream == false)
                    {
                        readFile.ReadLine();
                        fileBuilder.AppendLine(readFile.ReadLine());    //Append all even lines to StringBuilder
                    }
                }

                StreamWriter writeToFile = new StreamWriter(@"..\..\..\OddLineDeler.txt");
                using (writeToFile)
                {
                    writeToFile.Write(fileBuilder);     //Then Overwrite file with StringBulder contents
                }
            }
            catch (FileNotFoundException)
            {
                StreamWriter createFile = new StreamWriter(@"..\..\..\OddLineDeler.txt");
                Console.WriteLine("You were missing a file. Don't worry, I created it. Now I just need you to type something in it");
            }

        }
    }
}
