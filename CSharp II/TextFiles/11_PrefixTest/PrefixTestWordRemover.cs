using System.IO;
using System.Text.RegularExpressions;

namespace _11_PrefixTest
{
    /*Problem 11. Prefix "test"

    Write a program that deletes from a text file all words that start with the prefix test.
    Words contain only the symbols 0…9, a…z, A…Z, _.
                                                                            */
    class PrefixTestWordRemover
    {
        static void Main()
        {
            string temporaryHolderForDocument;
            using (StreamReader fileReader=new StreamReader(@"..\..\..\DeleteFromHere.txt"))
            {
                temporaryHolderForDocument = fileReader.ReadToEnd();    //Get file to memory
            }
            Regex replacePattern = new Regex("test\\w+");   //My skills with regex are not advanced enough to do the words should be"0…9, a…z, A…Z, _." condition, so I'll leave it like this
            //Create pattern

            temporaryHolderForDocument=replacePattern.Replace(temporaryHolderForDocument,string.Empty); //Delete all words with prefix "test"

            using (StreamWriter writeToMe =new StreamWriter(@"..\..\..\DeleteFromHereResult.txt"))
            {
                writeToMe.Write(temporaryHolderForDocument);    //Write modified text to new text file
            }
        }
    }
}
