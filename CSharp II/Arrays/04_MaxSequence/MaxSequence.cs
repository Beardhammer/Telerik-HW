using System;

namespace _04_MaxSequence
{
    /*Problem 4. Maximal sequence

    Write a program that finds the maximal sequence of equal elements in an array.

Example:
input 	result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1 	2, 2, 2                         */
    class MaxSequence
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("User-San, please enter the numbers for your array, separated by a space, and I, Sequence_Finder-Chan will definitely find a sequence for you!");
                string[] firstArray = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);   //User inputs their array

                int sequenceValidator = 0;
                int sequenceCounter = 0;
                string repeatedItem = "Sequence_Finder-Chan has not found any sequences! Does User-San want to try again?\n"; //Default value. Variable remains unchange if no sequences are found

                for (int i = 0; i < firstArray.Length-1; i++)   //Scans array
                {
                    if (firstArray[i] == firstArray[i + 1])     //Match is found
                    {
                        sequenceValidator++;
                        if (sequenceValidator >= sequenceCounter)   //Test to see whether current match is bigger than biggest recorded one
                        {                                           //If it is, then old match is replaced with current one 
                            repeatedItem = firstArray[i];
                            sequenceCounter = sequenceValidator;
                        }
                    }
                    else if (firstArray[i] != firstArray[i + 1])    //If currently scanned number aren't a match, then they are not recorded as a match, and match counter is reset
                    {
                        sequenceValidator = 0;
                    }
                }

                Console.WriteLine();
                Console.Write("User-San's sequence iiiiiiiiis:\n---->");
                for (int i = 0; i <= sequenceCounter; i++)    //Prints largest sequence-->Character of largest sequence printed y+1 times where y=length of sequence-1
                {
                    Console.Write(repeatedItem + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
