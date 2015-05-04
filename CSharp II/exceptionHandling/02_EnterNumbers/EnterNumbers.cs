using System;
using System.Collections.Generic;

namespace _02_EnterNumbers
{
    /*Problem 2. Enter numbers

    Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
        If an invalid number or non-number text is entered, the method should throw an exception.
    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
                                                                                                                                */
    class EnterNumbers  //I couldn't quite understand what is wanted of me in the problem description, so I made this according to what I think I'm supposed to do
    {
        static void Main()
        {
           InputRange();
        }

        static void InputRange()  //Nothing complex here, so there's no need describe much. Basically throws an exception at every chance to do so
        {
            int start = int.MinValue;
            int end = int.MinValue;

            Console.Write("Please enter your start range. It must be bigger than 1 and smaller than 100\n-->");
            if (int.TryParse(Console.ReadLine(), out start) == false) throw new Exception("Your start number is not a valid integer!");
            if (start>=100) throw new Exception("Your number cannot be bigger than 100!");
            if (start<1) throw new Exception("Your number cannot be smaller than 1!");

            Console.Write("Please enter your end range. It must be bigger than 1 and smaller than 100\n-->");
            if (int.TryParse(Console.ReadLine(), out end) == false) throw new Exception("Your end number is not a valid integer!");
            if (end <= start) throw new Exception("Your end number cannot be less than your start number!");
            if (end > 100) throw new Exception("Your number cannot be bigger than 100!");

            Input10NumInRange(start,end);
        }

        static void Input10NumInRange(int startRange, int endRange)
        {
            string validator = string.Empty;
            int currentNumber = 0;
            int lastNumber = 0;
            List<int> rays=new List<int>();

            Console.Write("Please enter 10 numbers in the range " + startRange + "-" + endRange+", exclusive, and I will throw and exception at every little mistake you make");
            for (int i = 0; i < 10; i++)
            {
                validator = Console.ReadLine();
                if (int.TryParse(validator, out currentNumber))
                {
                    if (currentNumber > lastNumber && currentNumber>startRange && currentNumber<endRange)
                    {
                        rays.Add(currentNumber);
                        lastNumber = currentNumber;
                    }
                    else
                    {
                        throw new Exception("Your input number is not valid.\nIt must be a number bigger than "+startRange+", smaller than "+endRange+", and must be bigger than the previous number");
                    }
                }
                else
                {
                    throw new Exception("Your input in not a valid integer!");                    
                }
            }
            Console.WriteLine("Your numbers: " + string.Join(", ", rays));
        }
    }
}
