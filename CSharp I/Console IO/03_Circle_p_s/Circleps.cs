using System;
using System.Globalization;
using System.Threading;

namespace _03_Circle_p_s
{
    /*Problem 3. Circle Perimeter and Area

    Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

Examples:
r 	perimeter 	area
2 	12.57 	12.57
3.5 	21.99 	38.48                                           */
    class Circleps
    {
        static void Main()      //Whole thing could be done in 2 lines, though that would leave a lot of room for errors
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter radius");
            while (true)                     //Special "while" used to keep the program running.....forever....spooky
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                string radiusValidator = Console.ReadLine();
                double radius;

                if (double.TryParse(radiusValidator, out radius))   //Checks input for non-numeric elements
                {
                    Console.WriteLine(((Math.PI)*(radius*radius)).ToString("N") + "\n" +(2*Math.PI*radius).ToString("N"));  //Calculates circle p and s
                }
              //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else
                {
                    Console.WriteLine("Your radius is invalid!");
                }
                Console.WriteLine("Wanna try another one?");    //Loops program
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
