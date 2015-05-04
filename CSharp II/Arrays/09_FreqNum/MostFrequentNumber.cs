using System;

namespace _09_FreqNum
{
    /*
     Problem 9. Frequent number

    Write a program that finds the most frequent number in an array.

Example:
input                               	result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	4 (5 times)                             */
    class MostFrequentNumber
    {
        static void Main()      //Note: Can be easily modified to find frequent strings as well
        {
            while (true)
            {
                Console.Write("Enter your numbers on a single line, separated by space\n-->");
                string[] userInputArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                /*{
            "g", "a", "5", "-1", "0", "g", "g", "3", "4", "5", "h", "g", "f","hg", "f", "4", "6", "g", "g",
            "f", "4", "6", "6", "g", "g", "4", "8", "6", "g", "q", "r", "6", "9", "g", "a", "5", "-1", "0", "g", "g",
            "3", "4", "5", "g", "f", "f", "4", "6", "g", "g", "f", "4", "6", "6", "g", "g", "4", "8", "6", "g", "q",
            "r",
            "6", "9", "n"
        };*/
                //Need some input? Here you go!

                int variousValidator = 0;
                int validItemsCounter = 0;

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

                Console.WriteLine("Array has been checked for invalid elements and now looks like this:\n" + "-->" + string.Join(", ", numberArray));        //Shows array after cleanup

                int foundNumber = 0;
                int currentCount = 0;
                int largestCount = 0;

                for (int i = 0; i < numberArray.Length; i++)        //Starts scanning array
                {
                    for (int e = 0; e < numberArray.Length; e++)    //After getting an index and the number in that index, starts scanning array for the same number
                    {
                        if (numberArray[i] == numberArray[e])       //If the same number is found
                        {
                            currentCount++;                         //Then the counter increases
                            if (currentCount > largestCount)        //If the number has been found more times than the previous one, then this number becomes the current number
                            {
                                foundNumber = numberArray[i];       //This is the number itself
                                largestCount = currentCount;        //This is how many times it has been found

                            }
                        }
                    }
                    currentCount = 0;   //Counter resets after end of "e" loop
                }
                Console.WriteLine("number " + foundNumber + " has been found " + largestCount + " times\n");    //Prints results
            }
        }
    }
}
