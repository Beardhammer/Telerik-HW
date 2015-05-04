using System;
using System.Text;

namespace _04_SubstringInText
{
    /*Problem 4. Sub-string in text

    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9                    */
    class SubstringInText
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter the text I will be searching in\n-->");
                string x = Console.ReadLine();
                //"The text is as follows: We are living in an yellow submarine. " +    //-->Example text. You should probably use this instead, but the option to enter your own text is here just in case
                //"We don't have anything else. inside the submarine is very tight. " +
                //"So we are drinking all the day. We will move out of it in 5 days.";

                Console.Write("What string shall I search for?\n-->");
                string seekingItem = Console.ReadLine(); //"in";
                int y = 0;

                int foundItem = 0;
                StringBuilder foundIndexes = new StringBuilder();

                while (foundItem + 1 < x.Length - 1)
                    //Don't see a point in using a separate method for this, so I didn't
                {
                    foundItem = x.ToLower().IndexOf(seekingItem.ToLower(), foundItem);  //needs finishing
                    if (foundItem < 0) break;
                    foundItem++;
                    foundIndexes.Append(foundItem + ", ");
                    y++;
                }
                Console.WriteLine("Item --> " + seekingItem + " has been found " + y + " times at indexes --> " + foundIndexes);
            }
        }
    }
}
