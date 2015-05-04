using System;

namespace _06_FirstLargerThanNeigh_bours_
{
    class FirstItemLargerThanItsNeighboursFinder
    {
        /*
         Problem 6. First larger than neighbours

    Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
    Use the method from the previous exercise.
                                                                                        */
        static void Main()
        {
            Console.Write("Please enter your array on a single line, separated by space\n-->");
            string[] numberArrayValidator = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] numberArray = new int[numberArrayValidator.Length]; //Whole block is array input validation
            //{1,43,43,4,4,5,27,27,78,887,342,442,454,47,907};

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

            Console.WriteLine("Your current array: " + String.Join(", ", numberArray));

            int index = GetFirstLargerString(numberArray);
            //int index = GetFirstLarger(numberArray);      //Use whichever of the 2 methods you like, but only 1 at a time

            if (index > -1)
            {
                Console.WriteLine("Index: " + index + " Element: " + numberArray[index]);
            }
            else
            {
                Console.WriteLine("Index: " + index + " NEIN!!!");
            }


        }

        static int GetFirstLarger(int[] numberArray)    //Use method from old exercise?! Impossible! It returns a string goddamnit!
        {
            for (int index = 1; index < numberArray.Length - 1; index++)
            {
                if (numberArray[index] > numberArray[index - 1] && numberArray[index] > numberArray[index + 1])
                {
                    return index;
                }
            }
            return -1;
        }

        static int GetFirstLargerString(int[] numberArray)  //This is the emthod from 05. Had to adapt it to use int32. Not much slower than the other one, I'm surprised!
        {
            for (int index = 0; index < numberArray.Length; index++)
            {
                int left = index > 0 ? //If index>0, then take value of numberArray[index-1], otherwise take value of numberArray[index]-1
                    numberArray[index - 1]
                    : numberArray[index] - 1;

                int right = index < numberArray.Length - 1 ? //If index<Max index, then take value of numberArray[index+1], otherwise take value of numberArray[index]-1
                    numberArray[index + 1]
                    : numberArray[index] - 1;

                if (numberArray[index] > left && numberArray[index] > right)
                {
                    return index;
                }
            }
            return -1;
        }
    }
}
