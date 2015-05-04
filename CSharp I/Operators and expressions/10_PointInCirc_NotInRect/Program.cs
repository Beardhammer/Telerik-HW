using System;
using System.Globalization;
using System.Threading;

namespace _10_PointInCirc_NotInRect
{
    /*Problem 10. Point Inside a Circle & Outside of a Rectangle

        Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

    Examples:
    x 	y 	inside K & outside of R
    1 	2 	yes
    2.5 	2 	no
    0 	1 	no
    2.5 	1 	no
    2 	0 	no
    4 	0 	no
    2.5 	1.5 	no
    2 	1.5 	yes
    1 	2.5 	yes
    -100 	-100 	no              */
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
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    bool pointInCircleCheck = (coordinateX - circleXPos) * (coordinateX - circleXPos) + (coordinateY - circleYPos) * (coordinateY - circleYPos) < (circleRadius * circleRadius);     //Formula used for the circle calculations. Its pure form(non-c#) is (x−h)^2+(y−k)^2=r^2
                    bool pointOutOfRectCheck = (coordinateX >= -1 && coordinateX <= 5) && (coordinateY >= -1 && coordinateY <= 1);
                    //coordinateX >= 2.5 ||coordinateX <= -0.5 && !(coordinateY > 2.5 || coordinateY <= 1);      //Used for out of recrangle calculations
                                                                                                                            
                    if (pointInCircleCheck==true & pointOutOfRectCheck==true)   //Checks if both conditions are true
                    {
                        Console.WriteLine("Point is inside the circle ...and out of the rectangle");
                    }
                    else
                    {
                        Console.WriteLine("Point is in the circle: " + pointInCircleCheck);
                        Console.WriteLine("Point out of the rectangle : " + pointOutOfRectCheck);
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
