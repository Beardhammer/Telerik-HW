using System;
using System.Text;

namespace _03_CorrectBrackets
{
    /*Problem 3. Correct brackets

    Write a program to check if in a given expression the brackets are put correctly.

Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).               */
    class CorrectBrackets
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your expression\n-->");

                var y = Console.ReadLine().ToCharArray();//"((()))((()))((((((()))))))()()()".ToCharArray();
                StringBuilder braces = new StringBuilder();

                for (int i = 0; i < y.Length; i++)      //Creates a string filled only with braces. Didn't use split for readibility improvements and regex because I don't know to use it correctly
                {
                    if (y[i] == '(' || y[i] == ')')
                    {
                        braces.Append(y[i]);
                    }
                }
                Console.WriteLine("Are they correct? " + CheckBrackets(braces));
            }
        }
        static bool CheckBrackets(StringBuilder input)   //This is the best I could do with my current skill level
        //I'm afraid there might be miscalculations with the loop condition, but I simply don't have the time to work on this anymore
        {
            int sizeValidator = 0;
            for (int i=0; sizeValidator != input.Length; i++)   //Basically replaces all occurences of "()" with empty space untill string is empty or there is nothing else to replace(marked by the size of the string not changing)
            {
                sizeValidator = input.Length;
                //Console.WriteLine("Length: " + input.Length); used in debugging the loop(Making sure it doesn't loop unnecessarily)

                input.Replace("()", String.Empty);  //It's possible to also implement my own replace method, but I don't see the point, so I won't 
                //Did you know you can chain these? Like:  input.Replace("()", String.Empty).Replace("()", String.Empty).Replace("()", String.Empty) and so on
            }
            return (input.Length == 0);
        }
    }
}
