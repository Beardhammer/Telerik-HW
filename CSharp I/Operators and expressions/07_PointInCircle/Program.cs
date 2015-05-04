using System;
using System.Globalization;
using System.Threading;

namespace _07_PointInCircle
{
    /*  Problem 7. Point in a Circle

    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

Examples:
x 	y 	inside
0 	1 	true
-2 	0 	true
-1 	2 	false
1.5 	-1 	true
-1.5 	-1.5 	false
100 	-30 	false
0 	0 	true
0.2 	-0.8 	true
0.9 	-1.93 	false
1 	1.655 	true
                            */
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                Console.WriteLine("Please input circle r(radius)");
                string validatorR = Console.ReadLine(); //Value of circle radius validator
                Console.WriteLine("Please input circle x position");
                string validatorCircleX = Console.ReadLine(); //Value of circle x position validator
                Console.WriteLine("Please input circle y position");
                string validatorCircleY = Console.ReadLine(); //Value of circle y position validator
            
            for (int i = 1; i <= 50000; i++)    //Keeps program looping
            {
                Console.WriteLine("Please input x coordinate");
                string validatorX = Console.ReadLine(); //Value of x(hoizontal) coordinate validator
                Console.WriteLine("Please input y coordinate");
                string validatorY = Console.ReadLine(); //Value of y(vertival) coordinate validator

                double coordinateX;     //Value of x(hoizontal) coordinate
                double coordinateY;     //Value of y(vertival) coordinate
                double circleRadius;    //Value of circle radius
                double circleXPos;      //Value of circle x position
                double circleYPos;      //Value of circle y position

                if (double.TryParse(validatorX, out coordinateX) & double.TryParse(validatorY, out coordinateY) & double.TryParse(validatorR, out circleRadius) & double.TryParse(validatorCircleX, out circleXPos) & double.TryParse(validatorCircleY, out circleYPos))        //Parses strings. without this "if", the program would crash if te user inputs something other than a number. Nested if is not used for the sake of code simplification and readability
                {
                    if ((coordinateX - circleXPos) * (coordinateX - circleXPos) + (coordinateY - circleYPos) * (coordinateY - circleYPos) <= (circleRadius*circleRadius))    //Formula used for the calculations. Its pure form(non-c#) is (x−h)^2+(y−k)^2=r^2
                    {
                        Console.WriteLine("Point is inside the circle");
                    }
                    else
                    {
                        Console.WriteLine("Point is not inside the circle");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. please try again");   //Error message in case of invalid input
                }
                    Console.WriteLine("Want to try again?\n");
            }//End for
        }
    }
}
