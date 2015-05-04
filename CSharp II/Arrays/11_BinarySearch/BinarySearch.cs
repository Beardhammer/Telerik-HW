using System;

namespace _11_BinarySearch
{
    /*Problem 11. Binary search

    Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
                                                                            */
    class BinarySearch  //At first I thought I was supposed to used binary search, not implement it *facepalm*, so I had to re-write the program, though since binary search is simple, it didn't take too much time
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter the array on a single line, separated by space\n-->");
                string[] userInputArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);     //User input in initial form

                int variousValidator = 0;
                var numberWeAreLookingFor = 0;
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
                Array.Sort(numberArray); //Quick sort

                Console.WriteLine("Please enter the number we will be searching for");
                string numberWeAreLookingForValidator = Console.ReadLine();

                if (int.TryParse(numberWeAreLookingForValidator, out numberWeAreLookingFor))
                {
                    Console.WriteLine("Your array is --> " + string.Join(", ", numberArray));   //Shows user the array that the program will be working with
                    
                    int start = 0;
                    int end = numberArray.Length - 1;
                    bool elementHasBeenFound = false;

                    for (int currentIndex = (numberArray.Length-1)/2; start<end;)   //This is binary search. Everything else is input validation....
                    {
                        if (numberArray[currentIndex] == numberWeAreLookingFor)
                        {
                            Console.WriteLine("The index of your element is --> " + currentIndex + "\n");
                            elementHasBeenFound = true;
                            break;
                        }
                        else if (numberArray[currentIndex] > numberWeAreLookingFor)
                        {
                            end = currentIndex/2;
                            currentIndex=(start + end-1)/2;
                        }
                        else if (numberArray[currentIndex] < numberWeAreLookingFor)
                        {
                            start = currentIndex;
                            currentIndex = (start + end+1) / 2;
                        }
                    }

                    if (!elementHasBeenFound)
                    {
                        Console.WriteLine("Element not found");
                    }
                }
                else    //Case user inputs bullshit to be searched for
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
            }
        }
    }
}
