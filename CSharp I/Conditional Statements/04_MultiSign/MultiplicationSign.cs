using System;
using System.Globalization;
using System.Threading;

namespace _04_MultiSign
{
    class MultiplicationSign
    {
        /*Problem 4. Multiplication Sign

    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        Use a sequence of if operators.

Examples:
a   	b 	    c 	result
5 	    2 	    2 	    +
-2 	    -2 	    1 	    +
-2 	    4 	    3 	    -
0 	    -2.5 	4 	    0
-1 	    -0.5 	-5.1 	-                   */
        static void Main()
        {
            while (true)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                Console.WriteLine("Thou shalt now inputeth thine numbers and separateth them by a space!");
              
                string[] userInputArray = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);  //User input is saved in this array

                double currentNumber = 0;
                int signIndicatorCounter = 0;
                string numSign="Holy hell! How did this happen??";               //Value is such in case something extremely wtf happens somewhere. Probably above 99.999999999999999999999% chance it won't, though

                foreach (string number in userInputArray)   //Cycles every character input by user
                {
                    if (double.TryParse(number, out currentNumber))     //Verifies numeric nature of all input characters
                    {
                        if (currentNumber == 0)                         //Case zero is found
                        {
                            numSign = "0";
                            break;
                        }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            if (currentNumber < 0)
                            {
                                signIndicatorCounter++;
                            }
                            if (currentNumber < 0)
                            {
                                signIndicatorCounter++;
                            }
                            if (currentNumber < 0)
                            {
                                signIndicatorCounter++;
                            }
                            if (signIndicatorCounter % 2 != 0)     //All numbers here can be considered negative results, because var increases+1 for every negative number given and 'cause -*-=+
                            {
                                numSign = "-";
                            }
                            else if (signIndicatorCounter % 2 == 0)
                            {
                                numSign = "+";
                            }
                            else
                            {
                                Console.WriteLine("Error! Something weird has just happened!\nPlease report all details of this as soon as possible\n");        //Case something unexpected happens. Probably won't, but gotta have it under control just in case
                            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    }
                    else
                    {
                        Console.WriteLine("\n" + number + " is not a double!\n");   //Case element from array can't be parsed
                    }
                }
                Console.WriteLine("Thine sign is: " + numSign + "Doth thee want to try another time?");
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
              
            }
        }
      }
}
/*x = x * Math.Sign(userFirstNumber);
  x = x * Math.Sign(userSecondNumber);
  x = x * Math.Sign(userThirdNumber);
  Console.WriteLine(x);*///Tried to create something with math. Didn't work. Brain can't operate well enough to finish method during all nighters :( Gonna leave this code here for future reference
