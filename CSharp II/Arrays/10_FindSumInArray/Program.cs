using System;

namespace _10_FindSumInArray
{
    /*Problem 10. Find sum in array

    Write a program that finds in given array of integers a sequence of given sum S (if present). ---> It clearly states SEQUENCE here and I refuse to do a messy extraction of every number regardles of position!

Example:
array 	S 	result
4, 3, 1, 4, 2, 5, 8 	11 	4, 2, 5         */
    class SumInArrayFinder
    {
        static void Main()      //Note: using var for numerics mean that the program won't be littered with integers, but the appropriat likely smaller types will be used, which increases efficiency(although very slightly at this stage)
        {
            while (true)
            {
                Console.Write("Mate, you gotta enter your numbers on a single line, and separate 'em by a line while you're at it!\n-->");
                string[] userInputArray = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                Console.Write("What number are you gonna search for?\n-->");
                String inputSumValidator = Console.ReadLine();

                var variousValidator = 0;
                var validItemsCounter = 0;
                var n = 0;

                if (!int.TryParse(inputSumValidator, out n))
                {
                    Console.WriteLine("Yikes Mate, your input isn't valid! Gotta try again!");
                    continue;
                }

                int[] numberArray = new int[userInputArray.Length]; //Creating new numeric array
                int indexForNumbers = 0;

                for (int i = 0; i < userInputArray.Length; i++)     //Old array is getting scanned
                {
                    if (int.TryParse(userInputArray[i], out variousValidator))  //Every number is passed to the new array and counter for the index is increased
                    {
                        numberArray[indexForNumbers] = variousValidator;
                        indexForNumbers++;                      //Counter for index. If I use "i" instead, there will be jumps on every index with a non-numeric value
                        validItemsCounter++;                    //Used for cutting off useless non-numeric items off aray.
                    }
                }

                Array.Resize(ref numberArray, validItemsCounter);      //Array gets resized according to instructing number

                var currentNumber = 0;
                string resultForPrint = string.Empty;
                bool thereIsNoSequence = true;

                for (var i = 0; i < numberArray.Length; i++)    //Scanning starts
                {
                    for (var e = i; e < numberArray.Length; e++)    //More scanning form current index onwards
                    {
                        currentNumber += numberArray[e];            //currentNumber keeps by adding its old value to the next number
                        resultForPrint += numberArray[e] + ", ";    //String also gets the numbers for printing later
                        if (currentNumber == n)
                        {
                            thereIsNoSequence = false;              //Only false if sequence is found
                            Console.WriteLine("Found you a sequence mate! Here: " + resultForPrint + "--> " + currentNumber);
                            i = numberArray.Length; //Breaking out of both loops
                            break;
                        }
                    }
                    resultForPrint = string.Empty;
                    currentNumber = 0;
                }

                if (thereIsNoSequence)
                {
                    Console.WriteLine("Crikey! There's no sequence whatsoever, mate.");
                }
            }
        }
    }
}
