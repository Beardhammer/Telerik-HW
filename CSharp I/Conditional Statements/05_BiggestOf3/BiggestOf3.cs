using System;
using System.Globalization;
using System.Threading;

namespace _05_BiggestOf3
{
    /*Problem 5. The Biggest of 3 Numbers

    Write a program that finds the biggest of three numbers.

Examples:
a 	b 	c 	biggest
5 	2 	2 	5
-2 	-2 	1 	1
-2 	4 	3 	4
0 	-2.5 	5 	5
-0.1 	-0.5 	-1.1 	-0.1                    */
    class BiggestOf3
    {
        static void Main()  //Basic variant. I tried a slightly different approach in BiggestOf5
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Thou shalt now inputeth thine first number");
            while (true)    
            {
                string userFirstNumberValidator = Console.ReadLine();
                double userFirstNumber;      //User inputs first number

                Console.WriteLine("Thou shalt now inputeth thine second number");
                string userSecondNumberValidator = Console.ReadLine();
                double userSecondNumber;     //User inputs second number

                Console.WriteLine("Thou shalt now inputeth thine third number");
                string userThirdNumberValidator = Console.ReadLine();
                double userThirdNumber;      //User inputs third number
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
               if (double.TryParse(userFirstNumberValidator, out userFirstNumber) &&
                    double.TryParse(userSecondNumberValidator, out userSecondNumber) &&
                    double.TryParse(userThirdNumberValidator, out userThirdNumber))             //Making sure all input is numeric
               {
                   double larger=Math.Max(userFirstNumber, userSecondNumber);       //Gets biggest of first 2 numbers
                   double largest = Math.Max(larger, userThirdNumber);              //Gets biggest of 3rd and larger(1st or 2nd) numbers
                   Console.WriteLine("\nThine biggest number is: " + largest);      //Prints biggest number
                   Console.WriteLine("Doth thee want to try with more numbers? Enter thine first one then!");
               }
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
