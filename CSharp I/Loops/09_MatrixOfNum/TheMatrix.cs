using System;

namespace _09_MatrixOfNum
{
    /*Problem 9. Matrix of Numbers

    Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

Examples:

n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1 2 3 4
        2 3                 2 3 4               2 3 4 5
                            3 4 5               3 4 5 6
                                                4 5 6 7
                            */
    class TheMatrix //Haha! I intially didn't fully read the conditions, inculding that n<20, so I was sitting here for 30+ minutes trying to find a way to fix errors in printing large numbers!
    {
        static void Main()
        {
            while (true)    //Matrix shall run indefinitely
            {
                Console.WriteLine("Please enter n");
                string nVal = Console.ReadLine();   //User inputs their matrix

                byte n = 0;

                if (byte.TryParse(nVal, out n) && n<55)     //Matrix is validated for non-numeric elements
                {
                    for (int i = 1; i <= n; i++)    //Part of formula. Responsible for jumping to next line in matrix
                    {
                        for (int e = i; e < i+n; e++)   //Works with single lines
                        {
                            Console.Write("{0,-3}", e); //Possibily with if rejected. Performance may possibly be lower and syntax less readable
                            if (n > 39)
                            {
                                Console.WindowWidth = n+110;    //Consolas fonts + 1680x1050 resolution used. Max was 210
                            }
                        }
                        Console.WriteLine();    //Jumps to next line
                    }
                }
                else
                {
                    Console.WriteLine("Parsing unsuccessful. Please check your input\nNote: n must be a positive number, greater than 0 and smaller than 55");  //Error message in case of unsuccessful parsing
                }
            }
        }
    }
}
