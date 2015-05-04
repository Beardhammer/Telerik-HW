using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _18_ExtractEmails
{
    /*Problem 18. Extract e-mails

    Write a program for extracting all email addresses from given text.
    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
                                                                                                                                        */
    class ExtractEmail  //Could be done either by appending to a stringBuilder or clearing invalid e-mail off a list. Both work the same(very slowly)
    {
        static void Main()  //In the end, I was forced into using regex. Really wanted not to, but I had no time left to try otherwise :(
        {
            string input = "Hello, my e-mails are examplemail@abv.bg and example@yahoo.com but not example@ yhoo.com or example@yahoo.";
            //I don't really think we need a Console.Readline() here. It would just slow down any checking, no? But feel free to replace it with a readline if you so desire. It's still gonna work

            List<string> retractorList = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            StringBuilder newBuilder = new StringBuilder();

            foreach (string item in retractorList)  //Basically, if it's an e-mail, it is appended to the stringbuilder
            {
                newBuilder.Append(Regex.IsMatch(item, @"[\w+-]+(?:\.[\w+-]+)*@[\w+-]+(?:\.[\w+-]+)*(?:\.[a-zA-Z]{2,4})") 
                    ? item + ", " 
                    : string.Empty);
            }
            Console.WriteLine("Valid e-mails: " + newBuilder);
            //Printing results
        }
    }
}
