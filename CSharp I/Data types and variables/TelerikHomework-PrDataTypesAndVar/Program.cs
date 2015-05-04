using System;
using System.Threading;
using System.Globalization;

namespace TelerikHomework_PrDataTypesAndVar //Problems 1 and 2-The program gives numbers correct data types and analyzes input number data type
{
    /*  Problem 1. Declare Variables

    Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.    */

    /*  Problem 2. Float or Double?

    Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
    Write a program to assign the numbers in variables and print them to ensure no precision is lost.   */

    class Program
    {
        static void Main(string[] args)  // 52130, -115, 4825932, 97, -10000 //34.567839023, 12.345, 8923.1234857, 3456.091
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.Title = "Some variables here and there. Definitely nothing wrong. No sir. I'm Just a normal console program.";
            ushort number1 = 52130;
            SByte number2 = -115;
            int number3 = 4825932;
            SByte number4 = 97;
            short number5 = -10000;
            double number6 = 34.567839023;
            float number7=12.345f;
            double number8 = 8923.1234857;
            float number9 = 3456.091f;
            Console.WriteLine(" " + number1 + "--" + number2 + "--" + number3 + "--" + number4 + "--" + number5 + "--" + number6 + "--" +  number7 + "--" +  number8 + "--" +  number9 + " ");
            Console.WriteLine("\nEnter your own number and I'll assign it a type! \nPlease only enter valid numbers\n");
//------------------------------------------------------------------------------------------------------------------------------------------------------------------         
            for (int i = 1; i <= 50000; i++)                      //Loops program until 50000th iteration
            {
                double userInputNumber;
                string checkForInvalidInput = Console.ReadLine();

            if (double.TryParse(checkForInvalidInput, out userInputNumber))                 //Checks whether the input is numeric or not
            {//Start of BIG If

                Console.WriteLine("\nIs it a decimal? " + ((userInputNumber % 1.0) != 0));            //Prints True or False depending on whether the number is a decimal or not
                Console.WriteLine("Is it a whole number? " + ((userInputNumber % 1.0) == 0) + "\n");  //Prints False or True depending on whether the number is a decimal or not

                Console.Write("And its type is--> ");                         //Prints first part of what type UserInputNumber is
//---------------------------------------------------Decimal--Numbers--Block---------------------------------------------------------------------------------------------------------------
                if ((userInputNumber % 1.0) != 0)                             //Checks if UserInputNumber is a decimal
                {
                    if (userInputNumber.ToString().Length < 9)                //Assigns UserInputNumber type float if its length is<9(Comma included)
                    {
                        Console.WriteLine("Float");
                    }
                    else if (userInputNumber.ToString().Length < 18)          //Assigns UserInputNumber type double if its length is<18(Comma included)
                    {
                        Console.WriteLine("Double");
                    }
                    else
                    {
                        Console.WriteLine("There seems to be an issue(Probably double overflow. Your iput is saved in a double, so don't try to overflow it). Please try again in a few minutes - with a different number...");
                        //In case of error
                    }
                }
//---------------------------------------------------Positive--Whole--Numbers--Block---------------------------------------------------------------------------------------------------------------
                else if ((userInputNumber % 1.0) == 0)              //Checks if UserInputNumber is a whole number(Else also possible. Do not use just in case)
                {//Start of SMALL else if
                    if (userInputNumber > 0)                        //Checks whether UserInputNumber has positive or negative value
                    {
                        if (userInputNumber < sbyte.MaxValue)       //This part of the shouldn't need any further description
                        {
                            Console.WriteLine("SByte");
                        }
                        else if (userInputNumber < byte.MaxValue)
                        {
                            Console.WriteLine("Byte");
                        }
                        else if (userInputNumber < short.MaxValue)
                        {
                            Console.WriteLine("Short");
                        }
                        else if (userInputNumber < ushort.MaxValue)
                        {
                            Console.WriteLine("UShort");
                        }
                        else if (userInputNumber < int.MaxValue)
                        {
                            Console.WriteLine("Int");
                        }
                        else if (userInputNumber < uint.MaxValue)
                        {
                            Console.WriteLine("UInt");
                        }
                        else if (userInputNumber < long.MaxValue)
                        {
                            Console.WriteLine("Long");
                        }
                        else if (userInputNumber < ulong.MaxValue)
                        {
                            Console.WriteLine("ULong");
                        }
                        else
                        {
                            Console.WriteLine("Out of range ");   //In case of error
                        }
                    }
//--------------------------------------------------Zero--And--Negative--Whole--Numbers--Block------------------------------------------------------------------------------------------------------------
                    else if (userInputNumber <= 0)                       //Checks whether UserInputNumber has positive or negative value or zero                               
                    {
                        if (userInputNumber > sbyte.MinValue)
                        {
                            Console.WriteLine("SByte");
                        }
                        else if (userInputNumber > short.MinValue)
                        {
                            Console.WriteLine("Short");
                        }
                        else if (userInputNumber > int.MinValue)
                        {
                            Console.WriteLine("Int"); 
                        }
                        else if (userInputNumber > long.MinValue)
                        {
                            Console.WriteLine("Long");
                        }
                        else
                        {
                            Console.WriteLine("Out of range ");
                        }
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }                                                        //End of SMALL else if
            }                                                            //End of BIG if      
            else
            {
                Console.Write("And its type is--> ");                                                 //Prints first part of what type UserInputNumber is
                Console.WriteLine("String!\nOr some kind of invalid input....");//("\nInvalid input/String detected!");   //Error message if input is non-numeric                     
            }             
            Console.WriteLine("\nWant to try another one?\n");           //Deletion may result in strange or abnormal/supernatural occurences. Delete at your own risk
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }//End For
        }
    }
}
