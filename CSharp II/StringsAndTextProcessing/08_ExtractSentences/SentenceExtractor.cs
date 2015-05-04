using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_ExtractSentences
{
    /*Problem 8. Extract sentences

    Write a program that extracts from a given text all sentences containing given word.

Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.                           */
    class SentenceExtractor
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your text and remember to separate each sentence :)\n-->");
                string userInputText = Console.ReadLine();
                    //"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

                Console.Write("What word will we be searching for?\n-->");
                string seekingItem = " " + Console.ReadLine().Trim() + " ";
                    //" in "; --> Note the spaces around "in". The string we are searching for is actually " in "

                List<string> userInputArray =
                    userInputText.Split(new[] {'.'}, StringSplitOptions.RemoveEmptyEntries).ToList();
                StringBuilder result = new StringBuilder();

                for (int i = 0; i < userInputArray.Count; i++)
                    //Could be extracted with a lambda expression instead, but I probably shouldn't fiddle around with something I don't fully understand
                {
                    //Considering all my lambda expressions so far have been slow as hell, this old fashioned for loop seems optimal
                    if (userInputArray[i].Contains(seekingItem))
                        //If our word is contained in a sentence, then it is appended to the stringBuilder
                    {
                        result.Append(userInputArray[i] + ".");
                    }
                }
                Console.WriteLine("Lines: " + result);
            }
        }
    }
}
