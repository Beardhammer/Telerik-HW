using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_ForbiddenWord
{
    /*Problem 9. Forbidden words

    We are given a string containing a list of forbidden words and a text containing some of these words.
    Write a program that replaces the forbidden words with asterisks.

Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.         */
    class CensoringMachine_NorthKoreanModel
    {
        static void Main()
        {
            //userInput.Replace("PHP", new string('*', "PHP".Length)).Replace("CLR", new string('*', "CLR".Length)).Replace("Microsoft", new string('*', "Microsoft".Length));
            //Also usable, but less dynamic. I dislike hard-coding what can be done otherwise unless there's large and needed performance boost that comes with t

            while (true)
            {
                StringBuilder userInput = new StringBuilder();
                Console.Write("Please enter your text, fellow brother Korean, and I brother Kim Park Woo of North Korean Great Nation will remove traitorous american words from text\n-->");
                userInput.Append(Console.ReadLine());//"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.");

                Console.Write("Please enter dirty american language words to block on single line and separate them by space\n-->");
                string keywordInput = Console.ReadLine();
                List<string> keywordContainer = keywordInput    //Gets all keywords entered
                                                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                                                .ToList();

                for (int i = 0; i < keywordContainer.Count; i++)    //This expression could be written as a one-liner without braces, but that is ill-advised as it impedes the readibility of the code sometimes
                {
                    userInput.Replace(keywordContainer[i], new string('*', keywordContainer[i].Length));    //Replaces all words that match keywords
                }
                Console.WriteLine("Great text now ready for eyes of North Korean people, no dirty american language left --> " + userInput);
            }

        }
    }
}
