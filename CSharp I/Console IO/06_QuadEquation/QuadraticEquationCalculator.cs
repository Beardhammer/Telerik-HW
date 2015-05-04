using System;
using System.Globalization;
using System.Threading;

namespace _06_QuadEquation
{
    /*Problem 6. Quadratic Equation

    Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

Examples:
a 	b 	c 	roots
2 	5 	-3 	x1=-3; x2=0.5
-1 	3 	0 	x1=3; x2=0
-0.5 	4 	-8 	x1=x2=4
5 	2 	8 	no real roots                   */
    class QuadraticEquationCalculator//Add dot istead of comma
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)                   //Special "while" used to keep program running.....forever....spooky
            {
                Console.WriteLine("Please enter a");                
                string num1Validator = Console.ReadLine();          //User a number. These "Validators" are used in input validation
                Console.WriteLine("Please enter b");
                string num2Validator = Console.ReadLine();          //User b number
                Console.WriteLine("Please enter c");
                string num3Validator = Console.ReadLine();          //User c number

                double a;
                double b;
                double c;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (double.TryParse(num1Validator, out a) &         //Checks whether the input is numeric and a>0. If a isn't >0, then the equation isn't quadratic
                    double.TryParse(num2Validator, out b) & 
                    double.TryParse(num3Validator, out c) & a>0)
                {  
                    if (((b*b) - 4*a*c)>=0)     //Case root/s is/are real numbers. Done this way to simplify code and increase readibility, therwise I would've had a separate case for 0
                    {
                        double x2 = (-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);    //Basic formula used in calculations
                        double x1 = (-b - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
                        string x1Signed = x1.ToString("+0.0000000000000000;-0.0000000000000000;+0");    //Forces elements to have a sign in front 
                        string x2Signed = x2.ToString("+0.0000000000000000;-0.0000000000000000;+0");    //Precision is high here because there are plenty of online calculators that aren't always as precise, so why not make mine useful while I'm at it?
                        Console.WriteLine("Your roots are: \nx1: " + x1Signed + "\nx2: " + x2Signed);   //Prints answer

                    }
                 //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    else if (((b * b) - 4 * a * c) < 0)    //Case roots are imaginary numbers
                    {
                        double x1 = (Math.Sqrt(((b * b) - 4 * a * c)*-1)) / (2 * a);    //Modified formula, so the computer doesn't fuck up and add the real number to the imaginary one
                        double x2 = -(Math.Sqrt(((b * b) - 4 * a * c)*-1)) / (2 * a);

                        double part1 = (-b)/(2*a);        //Part of modified formula

                        string x1Signed = x1.ToString("+0.0000000000000000;-0.0000000000000000;+0");    //Prints elements with sign and high precision. Very easy to modify precision
                        string x2Signed = x2.ToString("+0.0000000000000000;-0.0000000000000000;+0");
                        string answerImaginary =(string.Concat("x1: ",part1, x1Signed, "i", "\n","x2: ", part1, x2Signed, "i"));    //Created for the sake of simplicity. Easy to read and modify the way the answer is presented
                        Console.WriteLine("What are you doing here? How did you even get here?\n" +
                                          "Dude, what on earth did you input in order to get imaginary roots?" +
                                          "\n"+answerImaginary+"\nWanna try again anyway?\n");          //Prints answer
                    }
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    else
                    {
                        Console.WriteLine("Error!Error!Error!\nA very big error happened somewhere. Please try again.");    //In case something unexpected happens
                    }
                }
             //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else
                {
                    Console.Write("Your numbers are invalid. Please try again.");   //In case input is invalid
                }
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
