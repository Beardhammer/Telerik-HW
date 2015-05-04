using System;
using System.Globalization;
using System.Threading;

namespace _03_MinMaxSumAvgOfN
{
    /*
     Problem 3. Min, Max, Sum and Average of N Numbers

    Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    The output is like in the examples below.

Example 1:
input 	output
3
2
5
1 	min = 1
max = 5
sum = 8
avg = 2.67

Example 2:
input 	output
2
-1
4 	min = -1
max = 4
sum = 3
avg = 1.50                                  */
    class MinMaxSumAvg
    {
        static void Main()  //Code is a bit of a mess, eh? Fix it before uploading it!!!
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("Please enter your numbers on separate lines");

                string lengthValidator = Console.ReadLine();
                int length=1;   //User inputs how many rows will be used

                string currentNumValidator;
                double currentNum=0;    //Current Number. used later

                double sum = 0.00;      
                double average = 0.00;

                double maxNum = 0;
                double minNum = double.MaxValue;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (int.TryParse(lengthValidator, out length))  //First, "length" is checked for non-numeric elements
                {
                    for (int i = 1; i <= length; i++)           //Keeps reading input until number of rows specified by user is reached
                    {
                   //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        currentNumValidator = Console.ReadLine();   //User inputs number on row. Doubles are used, so don't worry about decimals
                        if (double.TryParse(currentNumValidator, out currentNum))   //Check input numbers for non-numeric elements
                        {
                   //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            if (currentNum > maxNum)    //Math.Min/Max rejected. This works just fine
                            {
                                maxNum = currentNum;    //Gets Max
                            }
                            if (minNum>currentNum)
                            {
                                minNum = currentNum;    //Gets Min
                            }
                            sum += currentNum;          //Gets sum
                   //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        }
                    }
                }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                average = (sum/length);                 //Gets average
                Console.WriteLine("\nMin: " + sum);     //Prints all these values
                Console.WriteLine("Max: " + maxNum);
                Console.WriteLine("Smallest: " + minNum);
                Console.WriteLine("Average: " + Math.Round(average, 2)); //average.ToString("N") is not usable. Conversions are too slow
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
