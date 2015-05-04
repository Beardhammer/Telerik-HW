using System;

namespace _05_LargerThanNeighbours
{
    /*Problem 5. Larger than neighbours

    Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
                                                    */
    class LargerThanNeighbours
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your array on a single line, separated by space\n-->");
                string[] numberArrayValidator = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                Console.Write("Now please enter what index we will be looking at\n-->");
                string seekingIndexValidator = Console.ReadLine();

                int seekingIndex = 0;
                if (int.TryParse(seekingIndexValidator, out seekingIndex))
                    //Checking seekingNumberValidator for non-numeric elements
                {
                    int[] numberArray = new int[numberArrayValidator.Length]; //Whole block is array input validation
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

                    Console.WriteLine("\nIs your number bigger than its neghbours? " +
                                      IsItBigger(numberArray, seekingIndex));
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
                Console.WriteLine("\nWanna try another one?\n");
            }
        }

        static string IsItBigger(int[] numberArray, int index)
        {
            int left = index > 0 ?             //If index>0, then take value of numberArray[index-1], otherwise take value of numberArray[index]-1
                numberArray[index - 1] :
                numberArray[index] - 1;

            int right = index < numberArray.Length - 1 ?    //If index<Max index, then take value of numberArray[index+1], otherwise take value of numberArray[index]-1
                numberArray[index + 1] :
                numberArray[index] - 1;

            if (numberArray[index] > left && numberArray[index] > right)
            {
                return "Yes";
            }
            return "No";

            //if (index > 0 && index < numberArray.Length - 1)      //Same performance as code above, but far more difficult to read, no?
            //{
            //    if (numberArray[index] > numberArray[index + 1] &&
            //        numberArray[index] > numberArray[index - 1])
            //    {
            //        return "Yes";
            //    }
            //    return "No";
            //}
            //else if (index == 0)
            //{
            //    if (numberArray[index] > numberArray[index + 1])
            //    {
            //        return "Yes";
            //    }
            //    return "No";
            //}
            //else if (index == numberArray.Length - 1)
            //{
            //    if (numberArray[index] > numberArray[index - 1])
            //    {
            //        return "Yes";
            //    }
            //}
            //return "No";

        }
    }
}
