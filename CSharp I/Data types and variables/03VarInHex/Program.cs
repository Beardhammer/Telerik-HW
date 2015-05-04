using System;
using System.Linq;

namespace _03VarInHex   //03-Variable in Hexadecimal Format-|Declares and int 254 in Hex and checks if it's correct|Plus it turns Hex to Dec and back
{
    /*  Problem 3. Variable in Hexadecimal Format

    Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
    Use Windows Calculator to find its hexadecimal representation.
    Print the variable and ensure that the result is 254.   */

    class Program   //Want some random colour backgrounds?!--->Idea rejected. Just sitting here to remind me to use it elsewhere
    {
        static void Main(string[] args)
        {
            int Hex254 = 0xFE;
            Console.WriteLine("The Decimal representation of 0xFE is " + Hex254);
            Console.WriteLine("Want to convert between Hexadecimal and Decimal? Type something!"); 
            int userInput;
       
            for (int i = 1; i <= 50000; i++)  //Loop keeps the program running
            {                                             
                string verifyInput = Console.ReadLine();       //Reads line
//-----------------------------------------------Case--Input--Is--Dec-------------------------------------------------------------------------------------------------------------------
                if (int.TryParse(verifyInput, out userInput))      //Checks for valid or invalid numbers//In case input is Dec
                {
                 string userHex = userInput.ToString("x");              //Turns Dec to Hex  
                 Console.Write("Hex: " + userHex);                      //Prints Hex
                 int decInput = int.Parse(userHex, System.Globalization.NumberStyles.HexNumber);    //Turns Hex back to Dec
                 Console.WriteLine(", Dec: " + decInput);               //Prints Dec
                 Console.WriteLine("Want to try another number?");      //Lets you input again                 
                }
//-----------------------------------------------Case--Input--Is--Hex-------------------------------------------------------------------------------------------------------------------
                else if (!verifyInput.Except("0123456789abcdefABCDEF").Any()) //Jessus Christ. This single line was the most difficult part of the entire homework project!
                {
                 string userDec = Convert.ToString(verifyInput);            //Turns Dec to Hex
                 int DecimalVal = Convert.ToInt32(userDec, 16);             //Turns Hex to Dec
                 Console.Write("Hex: " + userDec);                          //Prints Hex
                 Console.WriteLine(", Dec: " + DecimalVal);                   //Prints Dec
                }
//-----------------------------------------------Case--Input--Is--Invalid-------------------------------------------------------------------------------------------------------------------
                else   //Case input isn't Hexadecimal or Decimal
                {
                    Console.WriteLine("I'm not so sure your input is Hex or Dec.....Try again, I guess?");    
                }
            }//End For
        }
    }
}
