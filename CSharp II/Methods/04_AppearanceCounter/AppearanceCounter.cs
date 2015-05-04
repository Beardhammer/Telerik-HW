using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_AppearanceCounter
{
    /*
     Problem 4. Appearance count

    Write a method that counts how many times given number appears in given array.
    Write a test program to check if the method is workings correctly.
                                                                                            */
    class AppearanceCounter
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your array on a single line, separated by space\n-->");
                string[] numberArrayValidator = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                Console.Write("Now please enter what number we will be searching for\n-->");
                string seekingNumberValidator = Console.ReadLine();

                int seekingNumber = 0;
                if (int.TryParse(seekingNumberValidator, out seekingNumber))    //Checking seekingNumberValidator for non-numeric elements
                {
                    int[] numberArray = new int[numberArrayValidator.Length]; //Whole block is array input validation
                    int validator;
                    int index = 0;
                    foreach (var item in numberArrayValidator)
                    {
                        if (int.TryParse(item, out validator))
                        {
                            numberArray[index] = validator;
                            index++;
                        }
                    }
                    Array.Resize(ref numberArray, index); //End input validation

                    Console.WriteLine("Your current array: " + String.Join(", ", numberArray));

                    Console.WriteLine(new string('*', 50));     //Didn't make them return the number of times the element is found so I can make them print it themselves
                    WhereVersion(numberArray, seekingNumber);

                    Console.WriteLine(new string('-', 50));
                    LoopVersion(numberArray, seekingNumber);

                    Console.WriteLine(new string('-', 50));
                    FindFirstIndexOfVersion(numberArray, seekingNumber);

                    Console.WriteLine(new string('-', 50));

                }
                else
                {
                    Console.WriteLine("Invalid input"); //In case user input for seekingNumber is invalid
                }
                Console.WriteLine("\nDo you wish to try another array?\n");
            }
        }

        static void FindFirstIndexOfVersion(int[] numberArray, int seekingNumber)   //Unreliable and somewhat slow method
        {
            int index = 0;
            int seekingNumIndex = 0;
            int counter = 0;
            for (; index < numberArray.Length - 1 && seekingNumIndex>-1; )
            {
                seekingNumIndex = Array.FindIndex(numberArray, index, x => x == seekingNumber);  //Finds index of number
                index = seekingNumIndex + 1; //Fucks up if number is on both last and second-to-last positions 
                counter++;
            }
            if (numberArray[numberArray.Length-1]==seekingNumber && numberArray[numberArray.Length-2]==seekingNumber)   //Countermeasure for the issue described above. if-else isn't exactly slow, so there's no large performance difference
            {
                counter++;
            }
            Console.WriteLine("Method used: FindIndex(Lambda expression)\nYour item --> " + seekingNumber + " has been found " + counter + " times");
        }

        static void LoopVersion(int[] numberArray, int seekingNumber)   //Fastest and most realiable method
        {
            int counter = 0;
            foreach (var item in numberArray)   //Just loops through the whole array and increases counter for every instance of an element equal to seekingElement
            {
                if (item == seekingNumber)
                {
                    counter++;
                }
            }
            Console.WriteLine("Method used: Foreach Loop\nYour item --> " + seekingNumber + " has been found " + counter + " times");
        }

        static void WhereVersion(int[] numberArray, int seekingNumber)  //Very slow and somewhat reliable method
        {
            List<int> resultList = new List<int>(numberArray.Where(x => x == seekingNumber));   //Copies every instance of found element to a list
            Console.WriteLine("Method used: Where(Lambda expression)\nResult --> " + String.Join(", ", resultList) + "("+ seekingNumber+")"+" found " + resultList.Count + " times total");
        }
    }
}
