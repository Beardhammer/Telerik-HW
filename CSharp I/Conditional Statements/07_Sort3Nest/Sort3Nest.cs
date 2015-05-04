using System;
using System.Globalization;
using System.Threading;

namespace _07_Sort3Nest
{
    class Sort3Nest 
    {
        /*Problem 7. Sort 3 Numbers with Nested Ifs

    Write a program that enters 3 real numbers and prints them sorted in descending order.
        Use nested if statements.

Note: Don’t use arrays and the built-in sorting functionality.

Examples:
a 	b 	c 	result
5 	1 	2 	5 2 1
-2 	-2 	1 	1 -2 -2
-2 	4 	3 	4 3 -2
0 	-2.5 	5 	5 0 -2.5
-1.1 	-0.5 	-0.1 	-0.1 -0.5 -1.1
10 	20 	30 	30 20 10
1 	1 	1 	1 1 1                                           */
        static void Main()      //Could've used a loop, but it says to use nested ifs :(
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Thou shalt now inputeth thine numbers");
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

                if (double.TryParse(userFirstNumberValidator, out userFirstNumber) &&
                    double.TryParse(userSecondNumberValidator, out userSecondNumber) &&
                    double.TryParse(userThirdNumberValidator, out userThirdNumber)) //Making sure all input is numeric
                {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    //Anybody need some eggs? Yes, I'm referring to the lines below....
                    if (userFirstNumber >= userSecondNumber)    //Handled all cases here. Code is correct by accident. I thought I was writing it backwards, then it turns out correct! *facepalm*
                    {
                        if (userThirdNumber >= userFirstNumber)     
                        {
                            Console.WriteLine(" " + userThirdNumber + " " + userFirstNumber + " " + userSecondNumber);
                        }
                        else if (userThirdNumber <= userSecondNumber)  
                        {
                            Console.Write(" " + userFirstNumber + " " + userSecondNumber + " " + userThirdNumber);
                        }
                        else    
                        {
                            Console.WriteLine(" " + userFirstNumber + " " + userThirdNumber + " " + userSecondNumber);
                        }
                    }
                 //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    else if (userSecondNumber > userFirstNumber)
                    {
                        if (userThirdNumber >= userSecondNumber)
                        {
                             Console.Write(" " + userThirdNumber + " " + userSecondNumber + " " + userFirstNumber);
                        }
                        else if (userThirdNumber < userFirstNumber)
                        {
                             Console.Write(" " + userSecondNumber + " " + userFirstNumber + " " + userThirdNumber);
                        }
                        else
                        {
                             Console.Write(" " + userSecondNumber + " " + userThirdNumber + " " +userFirstNumber);
                        }
                    }
                  //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    else
                    {
                        Console.WriteLine("Sum ting-Wong"); //Case of error. I don't know what kind of error could possibly occur at this point, but as they say: Better to be safe than sorry
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
                Console.WriteLine("Wanna try some more numbers? Well enter thine first one, then!");    //Surprise! Program loops around here. 
            }
        }
    }
}
