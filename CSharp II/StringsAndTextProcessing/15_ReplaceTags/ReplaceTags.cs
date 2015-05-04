using System;
using System.Text;

namespace _15_ReplaceTags
{
    /*Problem 15. Replace tags

    Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

Example:
input 	output
<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>  */
    class ReplaceTags
    {
        static void Main()
        {
            StringBuilder replacerMachine = new StringBuilder();    //Yes, I got bored. It's not like the name's stupid, is it?

            Console.Write("Please enter your text and I'll change all those pesky tags for you!\n-->");
            string input = Console.ReadLine();//"<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course.\n Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            replacerMachine.Append(input);      //Using a string instead of a one-liner for readibility advantages

            Console.WriteLine("Your text before processing: " + replacerMachine);
            Console.WriteLine(new string('-', Console.WindowWidth));

            replacerMachine         //Doing the replacements
                .Replace("<a href=\"", "[URL=")
                .Replace("\">", "]")
                .Replace("</a>", "[/URL]");

            Console.WriteLine("Your text after processing: " + replacerMachine + "\n");
        }
    }
}
