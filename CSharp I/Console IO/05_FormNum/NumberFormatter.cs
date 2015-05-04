using System;
using System.Globalization;
using System.Threading;

namespace _05_FormNum
{
    /*Problem 5. Formatting Numbers

    Write a program that reads 3 numbers:
        integer a (0 <= a <= 500)
        floating-point b
        floating-point c
    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        The number a should be printed in hexadecimal, left aligned
        Then the number a should be printed in binary form, padded with zeroes
        The number b should be printed with 2 digits after the decimal point, right aligned
        The number c should be printed with 3 digits after the decimal point, left aligned.

Examples:
a 	b 	c 	result
254 	11.6 	0.5 	FE |0011111110| 11.60|0.500 |
499 	-0.5559 	10000 	1F3 |0111110011| -0.56|10000.000 |
0 	3 	-0.1234 	0 |0000000000| 3.00|-0.123 |                        */
    class NumberFormatter
    {
        static void Main() //Finish
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)                    //Special "while" used to keep program running.....forever....spooky
            {
                Console.WriteLine("Please enter dein first number");
                string num1Validator = Console.ReadLine();          //User first number
                Console.WriteLine("Please enter dein zecond number");
                string num2Validator = Console.ReadLine();          //User second number
                Console.WriteLine("Please enter dein drei number");
                string num3Validator = Console.ReadLine();          //User second number

                int num1;
                double num2;
                double num3;
                
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (int.TryParse(num1Validator, out num1) & double.TryParse(num2Validator, out num2) & double.TryParse(num3Validator, out num3) & (num1 <= 500 & num1 > 0))   //Input is checked for non-numeric elements
                {
                    string userHex = num1.ToString("X");        //Number is converted to hex
                    string DecimalVal = Convert.ToString(num1, 2).PadLeft(10, '0');     //Number is converted to binary
                    string num2String = num2.ToString("##.00").PadLeft(1);              //Number is formatted with 2 zeroes after decimal point and is aligned right
                    string num3String = num3.ToString("##.000").PadRight(1);            //Number is formatted with 3 zeroes after decimal point and is aligned left

                    Console.Write("|\n|" + userHex + "||" + DecimalVal + "||" + num2String + "||" + num3String + "|\n|");   //Result is printed
                }
                else
                {
                    Console.Write("\nWas zum Teufel machst du ?!\nIch bin nicht immer dafür bezahlt genug!!!!!!!\n\n");     //Input isn't valid and console goes MAD
                }
            }
        }
    }
}
