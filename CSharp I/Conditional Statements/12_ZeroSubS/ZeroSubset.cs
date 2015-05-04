using System;

namespace _12_ZeroSubS
{
    /*Problem 12.* Zero Subset

    We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
    Assume that repeating the same subset several times is not a problem.

Examples:
numbers 	result
3 -2 1 1 8 	-2 + 1 + 1 = 0
	
3 1 -7 35 22 	no zero subset
	
1 3 -4 -2 -1 	1 + -1 = 0
	1 + 3 + -4 = 0
	3 + -2 + -1 = 0
	
1 1 1 -1 -1 	1 + -1 = 0
	1 + 1 + -1 + -1 = 0
	
0 0 0 0 0 	0 + 0 + 0 + 0 + 0 = 0

Hint: you may check for zero each of the 31 subsets with 31 if statements.                      */

    internal class ZeroSubset
    {
        private static void Main()
        {
            while (true)
            {
                Console.Write("Write first number: ");
                string firstNumVal = (Console.ReadLine()); //User input the 5 numbers needed

                Console.Write("Write second number: ");
                string secondNumVal = (Console.ReadLine());

                Console.Write("Write third number: ");
                string thirdNumVal = (Console.ReadLine());

                Console.Write("Write fourth number: ");
                string fourthNumVal = (Console.ReadLine());

                Console.Write("Write fifth number: ");
                string fifthNumVal = (Console.ReadLine());

                int first = 0;
                int second = 0;
                int third = 0;
                int fourth = 0;
                int fifth = 0;

                if (int.TryParse(firstNumVal, out first) &&
                    int.TryParse(secondNumVal, out second) &&
                    int.TryParse(thirdNumVal, out third) &&
                    int.TryParse(fourthNumVal, out fourth) &&
                    int.TryParse(fifthNumVal, out fifth)) //Checking input for non-numeric elements
                {

                    bool result = false;
                    if (first + second == 0) //All calculations happen here
                    {
                        Console.WriteLine("{0} + {1} = 0", first, second);
                        result = true;
                    }
                    if (first + third == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", first, third);
                        result = true;
                    }
                    if (first + fourth == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", first, fourth);
                        result = true;
                    }
                    if (first + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", first, fifth);
                        result = true;
                    }
                    if (second + third == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", second, third);
                        result = true;
                    }
                    if (second + fourth == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", second, fourth);
                        result = true;
                    }
                    if (second + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", second, fifth);
                        result = true;
                    }
                    if (third + fourth == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", third, fourth);
                        result = true;
                    }
                    if (third + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", third, fifth);
                        result = true;
                    }
                    if (fourth + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", fourth, fifth);
                        result = true;
                    }
                    if (first + second + third == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", first, second, third);
                        result = true;
                    }
                    if (first + second + fourth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", first, second, fourth);
                        result = true;
                    }
                    if (first + second + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", first, second, fifth);
                        result = true;
                    }
                    if (first + third + fourth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", first, third, fourth);
                        result = true;
                    }
                    if (first + third + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", first, third, fifth);
                        result = true;
                    }
                    if (first + fourth + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", first, fourth, fifth);
                        result = true;
                    }
                    if (second + third + fourth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", second, third, fourth);
                        result = true;
                    }
                    if (second + fourth + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", second, fourth, fifth);
                        result = true;
                    }
                    if (second + third + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", second, third, fifth);
                        result = true;
                    }
                    if (third + fourth + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", third, fourth, fifth);
                        result = true;
                    }
                    if (first + second + third + fourth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} + {3} = 0", first, second, third, fourth);
                        result = true;
                    }
                    if (first + second + third + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} + {3} = 0", first, second, third, fifth);
                        result = true;
                    }
                    if (first + second + fourth + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} + {3} = 0", first, second, fourth, fifth);
                        result = true;
                    }
                    if (first + third + fourth + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} + {3} = 0", first, third, fourth, fifth);
                        result = true;
                    }
                    if (second + third + fourth + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} + {3} = 0", second, third, fourth, fifth);
                        result = true;
                    }
                    if (first + second + third + fourth + fifth == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", first, second, third, fourth, fifth);
                        result = true;
                    }
                    if (!result)
                    {
                        Console.WriteLine("there doesn't seem to be a zero subset..."); //Case no zero subset is found
                    }
                }
                else
                {
                    Console.WriteLine("You got invalid input, mate."); //Case input could not be parsed
                }
            }
        }
    }
}
