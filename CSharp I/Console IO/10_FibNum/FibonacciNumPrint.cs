using System;

namespace _10_FibNum
{
    /*Problem 10. Fibonacci Numbers

    Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

Note: You may need to learn how to use loops.

Examples:
n 	comments
1 	0
3 	0 1 1
10 	0 1 1 2 3 5 8 13 21 34          */
    class FibonacciNumPrint
    {
        static void Main()
        {
            while (true)                   //Special "while" used to keep the program running.....forever....spooky
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("Please enter how long you want the sequence to be");
                string numCountValidator = Console.ReadLine();
                int numCount;   //User defines length of fibonacci sequence. Input validation used to avoid crashes and exceptions

                if (int.TryParse(numCountValidator, out numCount))  //Input validation
                {
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    double a = 0;
                    double b = 1;

                    for (int i = 0; i < numCount; i++)              //Runs as many cycles as user has stated input in numCount
                    {
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        Console.Write(a+", ");  //Prints number
                        double c = a;           //Temporary var gets value of a
                        a = b;                  //a takes value of b(usually defined beforehand)
                        b = c + a;              //b takes value of c+a and then loop repeats, printing a, which had already taken the value of b in the prvious loop
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------

                    }
                }
                else
                {
                    Console.WriteLine("Unsuccessful parsing. Please recheck your input");   //Error message in case of unsuccessful parsing(input validation)
                }
             
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
