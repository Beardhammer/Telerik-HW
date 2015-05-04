using System;
using System.Globalization;
using System.Threading;

namespace _02_MoonWeightCalc
    /*Problem 2. Gravitation on the Moon

    The gravitational field of the Moon is approximately 17% of that on the Earth.
    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

Examples:
weight |weight on the Moon
86 	    14.62
74.6 	12.682
53.7 	9.129       */

{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("TELL ME your weight!");
            float userWeight;                   //Records user weight
            for (int i = 1; i <= 50000; i++)    //Keep program looping
            {
                string inputValidator = Console.ReadLine();     //Used in input validation
                if (float.TryParse(inputValidator, out userWeight))     //Checks if input is numeric
                {
                    Console.WriteLine("Wow. " + userWeight + "kg is a lot!\nMaybe you should come to the moon with us? You'll weigh " + 
                        ((userWeight * 17) / 100) + "kg there!");       //Prints result
                    Console.WriteLine("Want to try again?");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");   //Error message in case of invalid input
                }
                
            }
        }
    }
}
