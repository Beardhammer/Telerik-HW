using System;

namespace _08_MaxSumPr
{
    /*Problem 8. Maximal sum

    Write a program that finds the sequence of maximal sum in given array.

Example:
input 	result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	2, -1, 6, 4

    Can you do it with only one loop (with single scan through the elements of the array)?
                                                                                                            */
    class MaxSumPr
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter your numbers on single line, separated by space and I, Ivan as good soldier for motherland\n will find maximal sum in given array and annihilate all capitalist pig");
                string[] userInputArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                /*{
                "g", "a", "5", "-1", "0", "g", "g", "3", "4", "5", "h", "g", "f","hg", "f", "4", "6", "g", "g",
                "f", "4", "6", "6", "g", "g", "4", "8", "6", "g", "q", "r", "6", "9", "g", "a", "5", "-1", "0", "g", "g",
                "3", "4", "5", "g", "f", "f", "4", "6", "g", "g", "f", "4", "6", "6", "g", "g", "4", "8", "6", "g", "q",
                "r",
                "6", "9", "n"
            };*/
                //Need some input? Here you go! Please comment the while loop beforehand, though

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

                Console.WriteLine("Comrade, in case you put any stupid shit in array, I took liberty to check it and clean this shit.\nThis is array I will work with\n-->" + string.Join(", ", numberArray));
                int maxSum = 0;
                int currentSum = 0;
                string builder = string.Empty;

                //This is 95% of all I had to write, but you never know what the user's gonna input! We can't have the program crashing now can we?
                for (int i = 0; i < numberArray.Length; i++)
                {
                    currentSum += numberArray[i];   //Counting current sequence
                    builder += numberArray[i] + ", ";
                    if (currentSum > maxSum)        //If there's an increase in value, then it is saved
                    {
                        maxSum = currentSum;
                    }
                    else if (currentSum < 0)    //What about only negative numbers???  //Fuck that. After some experimentation, this seems to be the optimal implementation. Other variations seem to feature a large loss in performance for minimal gain
                    {
                        currentSum = 0;             //If there is no increase in value, then sequence is reset
                        builder = string.Empty;
                    }
                }

                if (maxSum!=int.MinValue)
                {
                    Console.WriteLine("Numbers:\n-->" + builder + "\nMax sum is:\n--> " + maxSum);  //Printing result here
                }
                else
                {
                    Console.WriteLine("No values, comrade"); //Printing result here
                }
            }
        }
    }
}
