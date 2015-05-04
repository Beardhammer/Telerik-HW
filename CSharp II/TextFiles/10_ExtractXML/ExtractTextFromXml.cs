using System;
using System.IO;
using System.Text;

namespace _10_ExtractXML
{
    /*Problem 10. Extract text from XML

    Write a program that extracts from given XML file all the text without the tags.

Example:

<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>   */
    class ExtractTextFromXml
    {
        static void Main()
        {
            StringBuilder fileText = new StringBuilder();
            string ourFile = string.Empty;

            using (StreamReader fileReader = new StreamReader(@"..\..\..\xmlFile.xml"))
            {
                ourFile = fileReader.ReadToEnd();   //First we put the xml file into a string
            }

            int x = ourFile.IndexOf('<', 0)+1;
            int y = 0;

            while (x>-1 && y>-1) //Started out as something simple, easy to understand and working well, then I discovered I need a line for every word and everything became a mess :(
            {
                x = ourFile.IndexOf('<',x);
                y = ourFile.IndexOf('>',y);
                if (x < 0 || y < 0) break;

                string yy = ourFile.Substring(y, x - y);    //Then we extract everything between every ">" and "<" and put it into a StringBuilder
                if (!string.IsNullOrWhiteSpace(yy) && yy != ">" && yy != "<")   
                {
                    fileText.AppendLine(ourFile.Substring(y+1, x - y-1));
                }

                y++;
                x++;
            }

            Console.Write("Results from your xml:\n"+fileText);     //Then we print the result on the console and write it to another file
            using (StreamWriter writeToMe = new StreamWriter(@"..\..\..\xmlFileResults.xml"))
            {
                writeToMe.Write(fileText);
            }

        }

        //static int GetFirstIndexOf(StringBuilder haystack, char needle, int startIndex=0) //For some reason StringBuilder doesn't have an IndexOf method, so I wrote one, but it's probably inefficient
        //{                                                                                 //Turns out there's nothing particularly wrong with my IndexOf. 
        //    if (startIndex >= haystack.Length) return -1;                                 //Problem is that initializing a StringBuilder is ridiculously slow, so it's only useful when manipulating a very long string of chars
        //    for (int i = startIndex; i < haystack.Length; i++)                            //I'll leave this method here in case you're too lazy to write one yourself :p
        //    {
        //        if (haystack[i] == needle) return i;
        //    }
        //    return -1;
        //}
    }
}
