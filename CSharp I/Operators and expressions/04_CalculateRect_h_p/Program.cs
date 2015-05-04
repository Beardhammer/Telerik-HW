using System;
using System.Globalization;
using System.Threading;

namespace _04_CalculateRect_h_p
{
    /*  Problem 4. Rectangles

    Write an expression that calculates rectangle’s perimeter and area by given width and height.

Examples:
width 	height 	perimeter 	area
3 	4 	14 	12
2.5 	3 	11 	7.5
5 	5 	20 	25
                        */
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Want to calculate the area and perimeter of a rectangle, yo?");
            float rectHeight;
            float rectWidth;

            for (int i = 1; i <= 50000; i++)
            {
                    string inputValidator = Console.ReadLine();        //Gets user input to be used for height

                if (float.TryParse(inputValidator, out rectHeight))    //Checks if input is numeric
                {                
                            inputValidator = Console.ReadLine();       //Gets value to be used for width

                        if (float.TryParse(inputValidator, out rectWidth))  //Checks if input is numeric
                        {
                            Console.WriteLine("The area of the given rectangle is: " + (rectHeight * rectWidth) );
                            Console.WriteLine("And its perimeter is: " + ((rectHeight + rectWidth) * 2));
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please try again");   //Error message in case of invalid input
                        }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");   //Error message in case of invalid input
                }
                
            }
        }
    }
}
