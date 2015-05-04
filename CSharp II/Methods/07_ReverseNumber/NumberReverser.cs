using System;
using System.Globalization;

namespace _07_ReverseNumber
{
    /*Problem 7. Reverse number

    Write a method that reverses the digits of given decimal number.

Example:
input 	output
256 	652
123.45 	54.321                                                          */
    class NumberReverser
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter the item you wish to be reversed\n-->");
                string reverser = ReverseNumber(Console.ReadLine());
                Console.WriteLine("Your results --> " + reverser);
            }
        }

        static string ReverseNumber(string number)  //No need for input validation
        {
            char[] characterArray = number.ToString(CultureInfo.InvariantCulture).ToCharArray();    //Stringbuilder would be too slow here
            for (int i = 0; i < characterArray.Length / 2; i++)     //Exchanges variables from both ends untill middle is reached
            {
                char temp = characterArray[i];
                characterArray[i] = characterArray[characterArray.Length - 1 - i];
                characterArray[characterArray.Length - 1 - i] = temp;
            }
            return string.Join("", characterArray);

            //if (number % 1 == 0)    //High performance for small numbers      //Failed code. Too many checks ruin all performance benefits that would be gained otherwise
            //{
            //    if (number < int.MaxValue/10 && number > int.MinValue/10)
            //    {
            //        int result = 0;
            //        int numberInt = Convert.ToInt32(number);

            //        while (numberInt > 0)
            //        {
            //            result = result * 10 + numberInt % 10;

            //            numberInt /= 10;
            //        }
            //        return result.ToString();
            //    }
            //    else        //Medium performance for large numbers
            //    {
            //        long result = 0;
            //        long numberInt = Convert.ToInt64(number);

            //        while (numberInt > 0)
            //        {
            //            result = result * 10 + numberInt % 10;

            //            numberInt /= 10;
            //        }
            //        return result.ToString();
            //    }
            //}
        }
    }
}
