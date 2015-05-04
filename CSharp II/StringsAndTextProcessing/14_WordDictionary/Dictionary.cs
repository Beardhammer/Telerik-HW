using System;
using System.Collections.Generic;

namespace _14_WordDictionary
{
    /*Problem 14. Word dictionary

    A dictionary is stored as a sequence of text lines containing words and their explanations.
    Write a program that enters a word and translates it by using the dictionary.

Sample dictionary:
input 	output
.NET 	platform for applications from Microsoft
CLR 	managed execution environment for .NET
namespace 	hierarchical organization of classes                            */
    class Dictionary
    {
        static void Main()
        {
            while (true)
            {
                Dictionary<string, string> wordDictionary = new Dictionary<string, string>()    //Turns out using a dictionary isn't so hard! Took me several minutes to write this
                {
                    {".net", "Platform for applications from Microsoft"},
                    {"clr", "Managed execution environment for .NET"},
                    {"namespace", "Hierarchical organization of classes"},
                    {"developer","A holy man that makes programs for us users"}
                    //{"Key","Value"} --> Notes
                };

                Console.Write("Please enter your word\n-->");
                string userInput = Console.ReadLine();

                Console.WriteLine("The definition for that word is: "+
                    (wordDictionary.ContainsKey(userInput.ToLower())
                    ?wordDictionary[userInput.ToLower()]
                    :"not found")+"\n");
            }
        }
    }
}
