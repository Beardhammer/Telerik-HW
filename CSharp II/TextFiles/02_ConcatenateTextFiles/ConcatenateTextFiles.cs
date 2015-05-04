using System.IO;
using System.Text;

namespace _02_ConcatenateTextFiles
{
    /*Problem 2. Concatenate text files

    Write a program that concatenates two text files into another text file.
                                                                                            */
    class ConcatenateTextFiles  //Bug: Concatenation doesn't newline on start of second file needs to be fixed. Edit: Fixed using AppendLine instead of Append
    {
        static void Main()
        {
            StringBuilder x = new StringBuilder();

            StreamReader firstText = new StreamReader(@"..\..\..\first.txt");
            StreamReader secondText = new StreamReader(@"..\..\..\second.txt");
            StreamWriter targetForWriting = new StreamWriter(@"..\..\..\concatenated.txt", false);

            using (firstText)   //Read first file and store it in StringBuilder
            {
                x.AppendLine(firstText.ReadToEnd());
            }
            using (secondText)  //Read second file and store it in StringBuilder
            {
                x.Append(secondText.ReadToEnd());
            }

            using (targetForWriting)    //Write contents of StringBuilder onto third file
            {
                targetForWriting.Write(x);
            }

            //x.Append(firstText.ReadToEnd());  //Alternate code with Close() instead of using(){}. It does exactly the same thing, but is slightly less readable if mixed with more code
            //firstText.Close();
            //x.Append(secondText.ReadToEnd());
            //secondText.Close();

            //targetForWriting.Write(x);
            //targetForWriting.Close();
        }
    }
}
