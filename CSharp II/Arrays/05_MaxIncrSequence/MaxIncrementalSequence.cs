using System;

namespace _05_MaxIncrSequence
{
    /*Problem 5. Maximal increasing sequence

    Write a program that finds the maximal increasing sequence in an array.

Example:
input 	result
3, 2, 3, 4, 2, 2, 4 	2, 3, 4                                     */
    class MaxIncrementalSequence
    {
        static void Main()  //At first, I though the sequence was supposed to only increase +1, but after reading 
        {                   //some on the forums, I got the idea it was just supposed to increase with no particular number in mind.
                            //Making the second version of the program that did that was quite a bit harder than the first version....
            while (true)
            {
                Console.WriteLine("May I ask you to enter the numbers for your array, separated by a space, sir");
                string[] firstArray = Console.ReadLine().Split(new []{ " " }, StringSplitOptions.RemoveEmptyEntries);   //User inputs their array

                int SequenceChecker = 0;
                int sequenceSize = 0;
                string repeatedItem = null;
                string numPrinter = null;

                int iCurrValidator = 0;
                int iNextValidator = 0;

                for (int i = 0; i < firstArray.Length - 1; i++)     //Scans array
                {
                    if (int.TryParse(firstArray[i], out iCurrValidator) && int.TryParse(firstArray[i+1], out iNextValidator))
                    {
                    
                        if (iNextValidator >= iCurrValidator)       //increasing sequence is found
                        {
                            SequenceChecker++;
                            repeatedItem += iCurrValidator + ", ";

                            if (SequenceChecker >= sequenceSize)    //Test to see whether current sequence is bigger than biggest recorded one
                            {                                       //If it is, then old sequence is replaced with current one 
                                sequenceSize = SequenceChecker;
                                numPrinter = repeatedItem + iNextValidator + ", ";
                            }
                        }
                        else if (iNextValidator < iCurrValidator)   //If currently scanned numbers aren't an increasing sequence, then they are not recorded as a match, and sequence counter is reset
                        {
                            SequenceChecker = 0;
                            repeatedItem = null;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sir, Invalid element detected! Please be more careful with your input next time!"); //In case some smartass inputs non-numeric elements
                    }
                }

                Console.WriteLine();
                Console.WriteLine(numPrinter);                      //Prints result
            }
        }
    }
}

