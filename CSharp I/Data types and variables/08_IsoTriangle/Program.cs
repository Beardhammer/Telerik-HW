using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_IsoTriangle
{
    /*  Problem 8. Isosceles Triangle

    Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

   ©

  © ©

 ©   ©

© © © ©

Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.   */

    class Program
    {
        static void Main(string[] args)//No>39
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Which one's cooler?\nVariation A :\n    ©\n\n   © ©\n\n  ©   ©\n\n © © © ©\n\nVariation B :\nNote: you can input the size yourself.\nNote 2: Beware of numbers>39. They cause glitches :(\n");
            for (int e = 1; e <= 50000; e++)
            {
                string userInputValidator = Console.ReadLine();
                int triangleSize;   //Used to adjust triangle size

                if (int.TryParse(userInputValidator, out triangleSize))
                {
                    for (int i = 1; i <= triangleSize; i++)    //Used in building second triangle
                    {
                        string triangle = " ";
                        Console.Write(triangle.PadLeft((triangleSize + 1) - i, ' '));   //Formula used for shape adjustment. Consists of the empty spaces before © symbols start getting drawn
                        Console.Write(triangle.PadLeft(i + i, '©') + "\n");    //This is also used for shape adjustment. Consists of © symbols drawn according to a simple formula and changes line when done
                    }
                    Console.WriteLine("Do you want to make another one?");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
            }
        }
    }
}
