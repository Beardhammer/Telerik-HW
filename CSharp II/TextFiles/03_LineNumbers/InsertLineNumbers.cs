using System.IO;
using System.Text;

namespace _03_LineNumbers   //Yup. That's right ladies and getlemen. No system directive(library). haha!
{
    /*Problem 3. Line numbers

    Write a program that reads a text file and inserts line numbers in front of each of its lines.
    The result should be written to another text file.
                                                                    */
    class InsertLineNumbers
    {
        static void Main()
        {
            StreamReader fileReader = new StreamReader(@"..\..\..\first.txt");
            StreamWriter insertNum = new StreamWriter(@"..\..\..\numbered.txt");

            //--------------------------Base--Code--------------------------------------

            using (fileReader)
            {
                using (insertNum)
                {
                    string x = fileReader.ReadLine();
                    for (int i = 1; !string.IsNullOrWhiteSpace(x); i++)
                        //Basically, we read a line, add a number in front of it, then print it in another document. I Kept the check for empty x as legacy code haha
                    {
                        insertNum.WriteLine(i + ": " + x);
                        x = fileReader.ReadLine();
                    }
                }
            }

            //--------------------------Alternate--Code---------------------------------

            //StringBuilder buildFile = new StringBuilder();  //Alternate code. Works slightly faster sometimes and slightly slower other times. It's more of a dice how it's gonna perform
            //buildFile.AppendLine("1: " + fileReader.ReadLine());

            //for (int i = 2; fileReader.EndOfStream == false; i++) //Basically, we read a line, add it to the stringBuilder, then when done, build the whole file from the stringBuilder
            //{
            //    //insertNum.WriteLine( x);
            //    buildFile.AppendLine(i + ": " + fileReader.ReadLine());
            //}

            //fileReader.Close();        //Done with close instead of using

            //using (insertNum)
            //{
            //    insertNum.Write((buildFile));
            //}
        }
    }
}
