using System;
using System.Linq;

namespace _04_BinSearch
{
    /*
     Problem 4. Binary search

    Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
                                                                                        */
    class BinarySearch
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your array on a single line, separated by space\n-->");     // {2, 3, 4, 5, 6, 7, 8, 8, 12, 13, 54, 87, 401, 403 };
                //User input whole array on a single line, separated by space
                string[] userInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Console.Write("What shall be your K?\n-->");
                string kNumVal = Console.ReadLine();
                double kNum = 0;

                if (double.TryParse(kNumVal, out kNum))     //Input validation for K
                {
                    var numArray = InputValidatorNumArray(userInput);   //Input validation
                    Array.Sort(numArray);
                    Console.WriteLine("Here is your current array:\n-->" + string.Join(", ", numArray));    //Printing array that will be used in calculations

                    int numberIndex = Array.BinarySearch(numArray, numArray.LastOrDefault(t => t <= kNum)); //Finding number
                    //Yesss! This is my first ever working lambda-ish expression :)    
                    if (numberIndex >= 0)
                    {
                        //Much of the code could be written on less lines, but I opted for multiple lines so I don't sacrifice readibility
                        Console.WriteLine("Your number --> " + numArray[numberIndex] + " is found at index --> " + numberIndex + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\nI couldn't find the number :(\n");
                    }
                }
                else
                {
                    Console.WriteLine("Sir, your K appears to be invalid!\n");  //Case user input non-numeric K
                }
                Console.WriteLine("Wanna try again?\n");
            }

            /*Here's the short version without input validation and with a possible OutOfRange exception :p
             * 
            int[] numArray = new[] {2, 3, 4, 5, 6, 7, 8, 8, 12, 13, 54, 87, 401, 403 };
            int kNum = 53 ;
            Console.WriteLine(numArray[Array.BinarySearch(numArray, numArray.LastOrDefault(t => t <= kNum))]);
              */
        }

        private static int[] InputValidatorNumArray(string[] userInput)
        {
            int[] numArray = new int[userInput.Length]; //Creating array
            int validator = 0;
            int indexResizer = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (int.TryParse(userInput[i], out validator))
                {
                    numArray[indexResizer] = validator; //Scanning initial array for numerics that will be passed to numeric array
                    indexResizer++;
                }
            }

            Array.Resize(ref numArray, indexResizer);   //Resizing numeric array to only fit found numeric elements
            return numArray;
        }
    }
}
