using System;

namespace _01_SquareRoot
{
    /*Problem 1. Square root

    Write a program that reads an integer number and calculates and prints its square root.
        If the number is invalid or negative, print Invalid number.
        In all cases finally print Good bye.
    Use try-catch-finally block.
                                                                */
    class SquareRootCalculator
    {
        static void Main()
        {
            while (true)
            {
                int squareRoot = 0;
                Console.Write("Please enter your integer\n-->");
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    squareRoot = (int)Math.Sqrt(input);

                    if (input < 0)
                    {
                        throw new ArithmeticException("Attempted to get sqrt of negative number. Actual number was: " + input);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number");
                }
                catch (ArithmeticException)
                {
                    Console.WriteLine("Invalid number ");
                }
                finally
                {
                    Console.WriteLine("Goodbye!");
                }
                Console.WriteLine(squareRoot);
            }
        }
    }
}
