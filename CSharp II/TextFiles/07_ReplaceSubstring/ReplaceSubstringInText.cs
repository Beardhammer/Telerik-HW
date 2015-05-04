using System.IO;
using System.Text;

namespace _07_ReplaceSubstring
{
    /*Problem 7. Replace sub-string

    Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
    Ensure it will work with large files (e.g. 100 MB).
                                                                        */
    class ReplaceSubstringInText
    {
        static void Main()
        {

            StringBuilder replacer = new StringBuilder();

            StreamReader fileReader = new StreamReader(@"..\..\..\Start.txt");

            for (int i = 0; fileReader.EndOfStream == false; i++)
            {
                replacer.AppendLine(fileReader.ReadLine().Replace("start", "finish"));
            }
            fileReader.Close();

            StreamWriter resultPrinter = new StreamWriter(@"..\..\..\Start.txt");
            using (resultPrinter)
            {
                resultPrinter.Write(replacer);
            }
        }
    }
}
