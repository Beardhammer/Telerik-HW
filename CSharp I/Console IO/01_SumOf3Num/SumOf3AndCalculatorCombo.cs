using System;
using System.Globalization;
using System.Threading;

namespace _01_SumOf3Num
{
    /*Problem 1. Sum of 3 Numbers

    Write a program that reads 3 real numbers from the console and prints their sum.

Examples:
a 	b 	c 	sum
3 	4 	11 	18
-2 	0 	3 	1
5.5 	4.5 	20.1 	30.1                */
    class SumOf3AndCalculatorCombo  //This program was made with code as simple as possible. At this point adding more features would mean more complex code, nested statements, and decreased readibility. At's about as simple as I can do :)
                                                                                                                                                                  //Actually the theme of this entire homework is simplicity, so get ready now!
    {                                                                                                                                                             //Actually, due to the simplicity of the program, while I know I've missed some errors, I haven't fixed them because that would mean writing difficult to read or nested code
        static void Main() //Yes, yes, I know at this point my program ain't all that simple, but there's not much you can do about it with so much otherwise error-prone code :(
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            while (true)                   //Special "while" used to keep the program running.....forever....spooky
            {
                Console.WriteLine("What shall I intialise, sire? SumOf3Numbers program?\nOr a calculator?\nOr maybe a quadratic equation calculator? 3/c/q"); //Initial question. Is not part of any other loop
                string user3orCalc = Console.ReadLine();            //User answer
                int loopValidator = 0;                              //Used in while loops
                int loopValidatorMini = 0;
//----------------------------------------------Normal--Calculator--Block--------------------------------------------------------------------------------------------------------------------
                if (user3orCalc == "c")    //Executed if user input at earlier question is c
                {
                    Console.WriteLine("Please input 1st number");
                    while (loopValidator == 0)                      //Look keep entire calculator repeating itself
                    {
                        var number1Validator = Console.ReadLine();  //Having validators helps with parsing, so program doesn't crash at wrong input
                       
                        Console.WriteLine("Please input 2nd number");
                        var number2Validator = Console.ReadLine();

                        double number1;
                        double number2;
                      //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        if (double.TryParse(number1Validator, out number1) &
                            double.TryParse(number2Validator, out number2))
                        {
                            Console.WriteLine("Action?+, -, *, /, ?\nNote:Sir, everything is done in the input order-->first number/second number\nNote 2: Using j here makes the program jump to the SumOf3Numbers part");
                            var userAction = Console.ReadLine();
                            loopValidatorMini = 0;
                            while (loopValidatorMini == 0)
                            {
                            //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                switch (userAction)                 //Performs action, based on user input
                                {
                                    case "+":
                                        Console.WriteLine("Result of your addition, sir: " + (number1 + number2));
                                        loopValidatorMini = 1;      //Used to escape loop
                                        break;
                                    case "-":
                                        Console.WriteLine("Result of your substraction, sir: " + (number1 - number2));
                                        loopValidatorMini = 1;      //Used to escape loop
                                        break;
                                    case "*":
                                        Console.WriteLine("Result of your multiplication, sir: " + (number1 * number2));
                                        loopValidatorMini = 1;      //Used to escape loop
                                        break;
                                    case "/":
                                        Console.WriteLine("Result of your division, sir: " + (number1 / number2));
                                        loopValidatorMini = 1;      //Used to escape loop
                                        break;
                                    case "j":
                                        loopValidatorMini = 1;      //Used to escape loop
                                        loopValidator = 1;          //Used to escape loops and jump to other code(Which is also looped)
                                        break;
                                    default:
                                        Console.WriteLine("Invalid action, sir"); 
                                        break;
                                }
                           //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            } //END
                        }
                        else
                        {
                            Console.WriteLine("Sire, your numbers appear to be invalid");   //In case of unsuccessful parsing
                        }
                        Console.WriteLine("\nWanna try again, sir? Input the 1st number then!\n");   //After successful calculation and loop
                    }
                }
//----------------------------------------------This--Is--The--01--Assignment--------------------------------------------------------------------------------------------------------------------
                else if (user3orCalc == "3")                        //Executed if user input at earlier question is 3
                {
                    Console.WriteLine("Please input 1st number, monseur");
                    while (loopValidator == 0)                      //Look keep entire SumOf3Numbers program repeating itself
                    {
                 //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        string number1Validator = Console.ReadLine();   //Having validators helps with parsing, so program doesn't crash at wrong input
                        Console.WriteLine("Please input the 2nd number now");
                        string number2Validator = Console.ReadLine();
                        Console.WriteLine("And also the 3rd number");
                        string number3Validator = Console.ReadLine();

                        double number1;
                        double number2;
                        double number3;
                     //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        if (double.TryParse(number1Validator, out number1) &   
                            double.TryParse(number2Validator, out number2) &
                            double.TryParse(number3Validator, out number3))
                        {
                            Console.WriteLine("Sir, the sum of your numbers is: " + (number1 + number2 + number3));  //Prints sum of 3 Valid numbers
                            Console.WriteLine("Pssst! Hey! This is Console!\nNow that you've tried the obligatory mode, wanna try the other calculator?y/n");
                            loopValidatorMini = 0;  //Try to use a for loop here next time
                            while (loopValidatorMini == 0)
                            {
                                string userYesNo = Console.ReadLine();
                                switch (userYesNo)  //Need to think of a simpler way to do this
                                {
                                    case "y":
                                        loopValidatorMini = 1;  //Used to escape loop
                                        loopValidator = 1;      //Used to escape loops and jump to other code(Which is also looped)
                                        break;
                                    case "n":
                                        Console.WriteLine("Console is sad :(\nIt took console very much time to write other calculator. Very sad");
                                        Console.WriteLine("\nVery sad but user try again?\nWrite 1st number then...");
                                        loopValidatorMini = 1;  //Used to escape loop
                                        break;
                                    default:
                                        Console.WriteLine("Your input is not valid. Try again, sir?");  //Thus response causes another loop which makes user try again
                                        break;
                                } //End case
                            } //End while
                        } //End if
                     //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        else
                        {
                            Console.WriteLine("Sir, your numbers must be invalid!");    //In case of unsuccessful parsing
                        }
                    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    } //End Mini While
                }
//----------------------------------------------End--Of--01--Assignment-->Quadratic--Equation--Block--------------------------------------------------------------------------------------------------------------------
                else if (user3orCalc == "q")
                {
                    loopValidator = 0;                      //Special number used to keep the program running.....forever....spooky
                    while (loopValidator==0)                    //Special "while" used to keep program running
                    {
                        Console.WriteLine("Sir may you please enter a?");
                        string num1Validator = Console.ReadLine();          //User a number. These "Validators" are used in input validation
                        Console.WriteLine("Could I ask you to input b now, sir>");
                        string num2Validator = Console.ReadLine();          //User b number
                        Console.WriteLine("Do you wish to enter c now?");
                        string num3Validator = Console.ReadLine();          //User c number

                        double a;
                        double b;
                        double c;
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        if (double.TryParse(num1Validator, out a) &         //Checks whether the input is numeric and a>0. If a isn't >0, then the equation isn't quadratic
                            double.TryParse(num2Validator, out b) &
                            double.TryParse(num3Validator, out c) & a > 0)
                        {
                            if (((b * b) - 4 * a * c) >= 0)     //Case root/s is/are real numbers. Done this way to simplify code and increase readibility, therwise I would've had a separate case for 0
                            {
                                double x2 = (-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);    //Basic formula used in calculations
                                double x1 = (-b - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
                                string x1Signed = x1.ToString("+0.0000000000000000;-0.0000000000000000;+0");    //Forces elements to have a sign in front 
                                string x2Signed = x2.ToString("+0.0000000000000000;-0.0000000000000000;+0");    //Precision is high here because there are plenty of online calculators that aren't always as precise, so why not make mine useful while I'm at it?
                                Console.WriteLine("Your roots appear to be: \nx1: " + x1Signed + "\nx2: " + x2Signed);   //Prints answer

                            }
                            //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            else if (((b * b) - 4 * a * c) < 0)    //Case roots are imaginary numbers
                            {
                                double x1 = (Math.Sqrt(((b * b) - 4 * a * c) * -1)) / (2 * a);    //Modified formula, so the computer doesn't fuck up and add the real number to the imaginary one
                                double x2 = -(Math.Sqrt(((b * b) - 4 * a * c) * -1)) / (2 * a);

                                double part1 = (-b) / (2 * a);        //Part of modified formula

                                string x1Signed = x1.ToString("+0.0000000000000000;-0.0000000000000000;+0");    //Prints elements with sign and high precision. Very easy to modify precision
                                string x2Signed = x2.ToString("+0.0000000000000000;-0.0000000000000000;+0");
                                string answerImaginary = (string.Concat("x1: ", part1, x1Signed, "i", "\n", "x2: ", part1, x2Signed, "i"));    //Created for the sake of simplicity. Easy to read and modify the way the answer is presented
                                Console.WriteLine("Console asks: What are you doing here? How did you even get here?\n" +
                                                  "What on earth did you input in order to get imaginary roots?" +
                                                  "\n" + answerImaginary + "\nWanna try again anyway?\n");          //Prints answer
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
                            Console.Write("Your numbers appear to be invalid, monseur. Please try again.");   //In case input is invalid
                        }
                        Console.WriteLine("Pssst! Hey! This is Console again!\nNow that you've tried the Quadratic equation, wanna try the other modes?y/n");
                        loopValidatorMini = 0;
                        while (loopValidatorMini == 0)
                        {
                            string userYesNo = Console.ReadLine();
                            switch (userYesNo)
                            {
                                case "y":
                                    loopValidatorMini = 1;  //Used to escape loop
                                    loopValidator = 1;      //Used to escape loops and jump to other code(Which is also looped)
                                    break;
                                case "n":
                                    Console.WriteLine("Console is sad :(\nIt took console very much time to write other modes. Very sad");
                                    Console.WriteLine("\nVery sad but user try again?\nWrite a number then...");
                                    loopValidatorMini = 1;  //Used to escape loop
                                    break;
                                default:
                                    Console.WriteLine("Your input is not valid. Try again, sir?");  //Thus response causes another loop which makes user try again
                                    break;
                            } //End case
                        } //End while
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
                else
                {
                    Console.WriteLine("Sir! How dare you! Your input is not valid!");   //In case user input differs from 3 or c
                }
            }//End Big While
//----------------------------------------------End--Of--Program--------------------------------------------------------------------------------------------------------------------
             
        }
    }
}/*|*/
