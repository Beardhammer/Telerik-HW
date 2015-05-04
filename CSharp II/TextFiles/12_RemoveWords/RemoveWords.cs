using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;   //Regex is such a slow way to do things!

namespace _12_RemoveWords
{
    /*Problem 12. Remove words

    Write a program that removes from a text file all words listed in given another text file.
    Handle all possible exceptions in your methods.
                                                                */
    class RemoveWords
    {
        static void Main()
        {
            try
            {
                List<string> wordsForRemoval=new List<string>();
                try
                {
                    using (StreamReader wordsForRemovalFile = new StreamReader(@"..\..\..\WordsForRemoval.txt"))
                    {
                        wordsForRemoval.AddRange(
                            wordsForRemovalFile.ReadToEnd()
                                .Split(new[] {' ', ',', '.', '!', '?', '"', '\'', '\\', ';', ':'},
                                    StringSplitOptions.RemoveEmptyEntries));
                        //Get all words from file
                    }
                }
                catch (FileNotFoundException)
                {
                    StreamWriter createFile=new StreamWriter(@"..\..\..\WordsForRemoval.txt");
                    createFile.Write("word, remove, removeme, gaelic, Johan Strauss, na bai ivan rakiqta ");
                }
                string x=string.Empty;
                try
                {
                    using (StreamReader fileReader = new StreamReader(@"..\..\..\RemoveWordsFromMe.txt"))
                    {
                        x = fileReader.ReadToEnd();
                        //Get file we are going to remove words from
                        foreach (string word in wordsForRemoval)
                        {
                            Regex wordRemove = new Regex("\\b" + word + "\\b");
                            x = wordRemove.Replace(x, string.Empty);
                            //Replace words with empty space
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    StreamWriter createFile = new StreamWriter(@"..\..\..\RemoveWordsFromMe.txt");
                    createFile.Write("word, remove, removeme, gaelic, Johan Strauss, na bai ivan rakiqta, nowords, noremove, donotremoveme, Mozart, Bach, Wolfgang, Naa bate ivo vodkata");
                }
               
                using (StreamWriter writer=new StreamWriter(@"..\..\..\WordsRemoved.txt"))
                {
                    writer.Write(x);
                    //Write new text to new file
                }
            }
            catch (UnauthorizedAccessException) //Just a wide variety of exceptions
            {
                Console.WriteLine("Are you trying to make me a criminal? You don't have access to that!");
            }
            catch (SecurityException)
            {
                Console.WriteLine("Yo nigga, wat dis mean? Watya tryin ta do? Nigga gots a security exception!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("There's a directory missing! Please re-download homework and try again");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The information(Path) you have entered is too long for my measly attention span to be able to process");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Your argument cannot be null. Please input an argument!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Something happened and I have no idea how to fix it, so please reset the program");
                throw;
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("The file you are trying to read is ridiculously huge. Please lose some weight and try again");
            }
            catch (IOException)
            {
                Console.WriteLine("I can't fix this either. Your HDD/SSD is probably under stress. Please try again later");
            }
            catch (RegexMatchTimeoutException)
            {
                Console.WriteLine("Your toaster has probably overheated by now if you get this exception(Regex timeout).\nPlease shut it down and let it cool down for 10-15 minutes and try again");
            }
        }
    }
}
