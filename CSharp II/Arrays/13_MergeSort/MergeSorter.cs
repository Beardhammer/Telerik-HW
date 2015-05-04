using System;

namespace _13_MergeSort    
{
    /*Problem 13.* Merge sort

    Write a program that sorts an array of integers using the Merge sort algorithm.
                                                                                            */
    internal class MergeSorter
    {
        private static void Main()  
        {
            Console.WriteLine("Please enter the numbers that will be sorted on a single line, sparated by space");
            string[] userInputArray = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries); //User input

            int[] numberArray=new int[userInputArray.Length];
            int index = 0;
            int validator = 0;
            for (int i = 0; i < userInputArray.Length; i++)     //Input validation
            {
                if (int.TryParse(userInputArray[i], out validator)) //All numeric values are cloned into numberArray, while non-numeric ones are ignored
                {
                    numberArray[index] = validator;
                    index++;
                }
            }
            Array.Resize(ref numberArray,index);    //Size of numberArray is cut to only have numeric values
            //int[] numberArray = { 1, 6, 7, 4, 8, 90, 4, 43, 6, 1, 6, 7, 4, 8, 90, 4, 43, 6, 96968 };

            numberArray = MergeSort(numberArray);       //Merge sort
            Console.WriteLine(string.Join(", ", numberArray));  //Displaying results
        }

        private static int[] MergeSort(int[] numberArray)
        {
            //throw new NotImplementedException();
            if (numberArray.Length <= 1)    //If array is too small, no additional actions are taken here
            {
                return numberArray;
            }

            int middle = numberArray.Length / 2;    //Creating 2 new array. One for the left half, and one for the right half of the numbers
            int[] left = new int[middle];
            int[] right = new int[numberArray.Length - middle];

            int i = 0;
            int j = 0;

            for (i = 0; i < middle; i++)    //Populating the 2 new array with values from the original array
            {
                left[i] = numberArray[i];
            }
            for (i = 0, j = middle; j < numberArray.Length; j++, i++)
            {
                right[i] = numberArray[j];
            }

            left = MergeSort(left);         //This is what's called recursion, right? When a method calls itself?
            right = MergeSort(right);

            return MergedArray(left, right);    //Returning more orderly array

        }

        private static int[] MergedArray(int[] left, int[] right)
        {
            //throw new NotImplementedException();
            int[] result = new int[left.Length + right.Length]; //Creating new array to hold sorted items of the 2 smaller ones from earlier

            int i = 0;
            int j = 0;

            for (i = 0, j = 0; i < result.Length && i < left.Length && j < right.Length; )  //Sorting new array, using values from "left" and "right"
            {
                if (left[i] < right[j])
                {
                    result[i + j] = left[i];
                    i++;
                }
                else
                {
                    result[i + j] = right[j];
                    j++;
                }
            }
            for (; i < left.Length; i++)
            {
                result[i + j] = left[i];
            }

            for (; j < right.Length; j++)
            {
                result[i + j] = right[j];
            }

            return result;  //Returning ordered array
        }
    }
}