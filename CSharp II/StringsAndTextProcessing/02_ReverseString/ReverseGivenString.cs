using System;
using System.Text;

namespace _02_ReverseString
{
    /*Problem 2. Reverse string

    Write a program that reads a string, reverses it and prints the result at the console.

Example:
input 	output
sample 	elpmas                              */
    class ReverseGivenString
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your string and I will reverse it\n-->");
                string reversedItem = Console.ReadLine();   

                Console.WriteLine("Your string reversed using char array -----> " + ReverseStringWithCharArray(reversedItem));
                Console.WriteLine("Your string reversed using stringbuilder --> " + ReverseStringWithStringBuilder(reversedItem));
            }
        }

        static string ReverseStringWithCharArray(string userString)
        {
            char[] stringReverseArray = userString.ToCharArray();   //Needs to be modified to use list instead
            Array.Reverse(stringReverseArray);                      //Just inverts the whole array
            return string.Join("", stringReverseArray);
        }

        static string ReverseStringWithStringBuilder(string userString)
        {
            StringBuilder stringReverser = new StringBuilder();
            stringReverser.Append(userString);
            for (int i = 0; i < stringReverser.Length / 2; i++)   //length/2 is used to avoid switching the middle character in an odd-sized string
            {
                char temp = stringReverser[i];                  //Basically swaps the first and last characters of a string over and over again
                stringReverser[i] = stringReverser[stringReverser.Length - i - 1];
                stringReverser[stringReverser.Length - i - 1] = temp;
            }
            return stringReverser.ToString();
        }
    }
}
