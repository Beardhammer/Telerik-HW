using System;
using System.Text;

namespace _05_ParseTags
{
    /*Problem 5. Parse tags

    You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
    The tags cannot be nested.

Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.                              */
    class ParseTags
    {
        static void Main()
        {
            //while (true)
            {
                Console.Write("Please enter the text I will be searching in\n-->");
                string userInput = Console.ReadLine();//"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
                Console.WriteLine(SwapToUpCase(userInput));
            }
        }

        private static StringBuilder SwapToUpCase(string inputString)
        {
            StringBuilder foundIndexes = new StringBuilder();
            foundIndexes.Append(inputString);

            int indexUp = 0;
            int indexEndUp = 0;

            while (indexUp + 1 < inputString.Length - 1) 
            {
                indexUp = inputString.IndexOf("<upcase>", indexUp); //Untill there are none left, we keep searching for <upcase>
                indexEndUp = inputString.IndexOf("</upcase>", indexEndUp); //And for </upcase>

                if (indexUp < 0 || indexEndUp < 0) break; //If no more are found, break, otherwise increase both index variables, so they don't find the same item again
                indexEndUp++;
                indexUp++;

                if (indexUp < indexEndUp) //If <upcase> is found in index before </upcase>
                {
                    string inUpCase = inputString.Substring(indexUp - 1, (indexEndUp - indexUp) + 9)
                        .Replace("<upcase>", string.Empty)
                        .Replace("</upcase>", string.Empty)
                        .ToUpper();       //Then get everything between their indexes, remove <upcase> and </upcase> and make it uppercase

                    string willBeReplaced = inputString.Substring(indexUp - 1, (indexEndUp - indexUp) + 9); //Then get it all again --> there's gotta be better methods than this!
                    foundIndexes.Replace(willBeReplaced, inUpCase); //And swap the fuckers
                    
                    //        foundIndexes.Replace(
                    //(inputString.Substring(indexUp - 1, (indexEndUp - indexUp) + 9)),    //This should work faster. In theory. Maybe.
                    //(inputString.Substring(indexUp - 1, (indexEndUp - indexUp) + 9)      // Too bad most people can't read the holy asjasjhkjhdhaksj language :(                 
                    //    .Replace("<upcase>", string.Empty)                               //--> Basically, I didn't use it because it's unreadable
                    //    .Replace("</upcase>", string.Empty)
                    //    .ToUpper())
                    //    );
                }
            }

           return foundIndexes.Replace("<upcase>", string.Empty).Replace("</upcase>", string.Empty);  //And when done, remove any leftover <upcase> or </upcase> left and return it
        }
    }
}
