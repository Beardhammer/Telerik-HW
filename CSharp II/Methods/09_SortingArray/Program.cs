using System;

namespace _09_SortingArray
{
    /*Problem 9. Sorting array

    Write a method that return the maximal element in a portion of array of integers starting at given index.
    Using it write another method that sorts an array in ascending / descending order.
                                                                                                                        */
    class ArraySorter
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your array on a single line, separated by spaces\n-->");
                string[] numberArrayValidator = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                int[] numberArray = new int[numberArrayValidator.Length]; //Whole block is array input validation
                //{1, 43, 43, 4, 4, 5, 27, 27, 78, 887, 342, 442, 454, 47, 907};
                //{ 48, 432, 452, 47, 43, 543, 4565, 45, 46, 42, 32, 12, 41, 6, 689 };

                int validator;
                int indexer = 0;
                foreach (var item in numberArrayValidator)
                {
                    if (int.TryParse(item, out validator))
                    {
                        numberArray[indexer] = validator;
                        indexer++;
                    }
                }
                Array.Resize(ref numberArray, indexer); //End input validation

                while (true)
                {
                    Console.Write("Your current array --> " + string.Join(", ", numberArray) +
                                  "\nWhat will we do with the array?\n1-->Sort it in an ascending manner\n2-->Sort it in a descending manner\n3-->Get tha max number in the array from given index onwards\n-->");
                    string userAnswer = Console.ReadLine();

                    if (userAnswer == "1")  //User chooses what to do
                    {
                        numberArray = SortArrayАscending(numberArray);
                        Console.WriteLine("Your array, sorted in an ascending manner: " + string.Join(", ", numberArray));
                        break;
                    }
                    else if (userAnswer == "2")
                    {
                        numberArray = SortArrayDescending(numberArray);
                        Console.WriteLine("Your array, sorted in a descending manner: " + string.Join(", ", numberArray));
                        break;
                    }
                    else if (userAnswer == "3")
                    {
                        Console.Write("Please enter your start index\n-->");
                        string startIndexVal = Console.ReadLine();
                        int startIndex = 0;
                        if (int.TryParse(startIndexVal, out startIndex) && startIndex > -1 &&
                            startIndex < numberArray.Length)
                        {
                            int max = GetMaxInArray(numberArray, startIndex);
                            Console.WriteLine("The maximum number from index " + startIndex + " onwards is " + max +
                                              " at index " + Array.FindIndex(numberArray,x=>x==max));
                            break;
                        }
                        Console.WriteLine("\nInvalid index! Please try again when sober!\n");
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input!\n");
                    }
                }
            }

        }

        static int GetMaxInArray(int[] numberArray, int startIndex)
        {
            int max = int.MinValue;
            for (int i = startIndex; i < numberArray.Length; i++)   //Loops through whole array and finds biggest number
            {
                if (numberArray[i] > max)
                {
                    max = numberArray[i];
                }
            }
            return max; 
        }
        static int[] SortArrayDescending(int[] numberArray) //Slower than selection sort! --> ~600-700ms vs ~1000ms => 1mil loops
        {
            int[] resultArray = new int[numberArray.Length];
            for (int j = 0; j < resultArray.Length; j++)
            {
                int max = int.MinValue;
                int maxIndex = 0;
                for (int i = 0; i < numberArray.Length; i++)
                {
                    if (numberArray[i] > max)   //Largest number is->
                    {
                        max = numberArray[i];
                        maxIndex = i;
                    }
                }
                numberArray[maxIndex] = int.MinValue;   //->added to resulting array and then nulled to int.MinValue in order to be skipped next loop
                resultArray[j] = max;
            }
            return resultArray;
        }
        static int[] SortArrayАscending(int[] numberArray)
        {
            int[] resultArray = new int[numberArray.Length];    //Creating array to hold sorted numbers
            for (int j = 0; j < resultArray.Length; j++)    
            {
                int min = int.MaxValue;
                int minIndex = 0;
                for (int i = 0; i < numberArray.Length; i++)
                {
                    if (numberArray[i] < min)   //Largest number is->
                    {
                        min = numberArray[i];
                        minIndex = i;
                    }
                }
                numberArray[minIndex] = int.MaxValue;   //->added to resulting array and then maxed to int.MaxValue in order to be skipped next loop
                resultArray[j] = min;
            }
            return resultArray;
        }
    }
}
