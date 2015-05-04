using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SumIntegers
{
    /*Problem 6. Sum integers

    You are given a sequence of positive integer values written into a string, separated by spaces.
    Write a function that reads these values from given string and calculates their sum.

Example:
input 	output
"43 68 9 23 318" 	461                     */
    class SumIntegers
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your numbers in a single line, separated by space or a comma\nNote: All negative and non-numeric values are ignored\n-->");
                string[] userStrings = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

                //List<double> userDoubles=new List<double>();  //No need for list, but I'll leave some code here just in case

                uint validator = 0;
                //int index = 0;
                uint sum = 0;
                for (int i = 0; i < userStrings.Length; i++)
                {
                    if (uint.TryParse(userStrings[i], out validator)) //userDoubles[index++] = validator;
                    {
                        sum += validator;
                    }
                }

                Console.WriteLine("Your sum is --> " + sum + "\n");
            }
        }
    }
}
