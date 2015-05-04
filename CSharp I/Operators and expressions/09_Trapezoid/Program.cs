using System;
using System.Globalization;
using System.Threading;

namespace _09_Trapezoid
{
    /*Problem 9. Trapezoids

        Write an expression that calculates trapezoid's area by given sides a and b and height h.

    Examples:
    a 	b 	h 	area
    5 	7 	12 	72
    2 	1 	33 	49.5
    8.5 	4.3 	2.7 	17.28
    100 	200 	300 	45000
    0.222 	0.333 	0.555 	0.1540125           */
    class Program 
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Want to calculate the area of a trapezoid?");

            for (int i = 1; i <= 50000; i++)
            {
                Console.WriteLine("Please input side a");   //User inputs trapezoid data here
                string inputValidator = Console.ReadLine();
                Console.WriteLine("Please input side b");
                inputValidator = Console.ReadLine();
                Console.WriteLine("Please input height");
                inputValidator = Console.ReadLine();

//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                float trapSideA;    //Holds side a
                float trapSideB;    //Holds side b
                float trapHeight;   //Hold h
                
                if (float.TryParse(inputValidator, out trapHeight) & float.TryParse(inputValidator, out trapSideB) & float.TryParse(inputValidator, out trapSideA)) //Nested if functionality discarded in favor of simpler, more readable code. Good, no?
                        {                                                                                                                                           //All parameters have to be parsed successfully in order to execute this code
                            Console.WriteLine("Area of given trapezoid is: " + ((trapSideA+trapSideB)/2)*trapHeight);   //Prints area of trapezoid according to calculations
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for h. Please retry");
                        }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\nWanna try again?");
            }
        }
    }
}
