using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InvertSentence
{
    /*Problem 13. Reverse sentence

    Write a program that reverses the words in given sentence.

Example:
input 	output
C# is not C++, not PHP and not Delphi! 	Delphi not and PHP, not C++ not is C#!                      */
    class ReverseSentence
    {
        static void Main()  //Need to finish this. How do I ignore the commas without regex?
        {
            Console.Write("Please enter your text and I will reverse it word by word\n-->");
            string input = Console.ReadLine();//"C# is not C++, not PHP and not Delphi!";

            List<string> x =input.Split(new[] {' ', '.', ',',';','!','?',}, StringSplitOptions.RemoveEmptyEntries).ToList();
            string y = string.Empty;

            for (int i = 0; i < x.Count/2; i++)
            {
                y = x[i];
                x[i] = x[x.Count - i - 1];
                x[x.Count - i - 1] = y;
            }
            Console.WriteLine("Your sentence: " + string.Join(" ", x));
        }
    }
}
