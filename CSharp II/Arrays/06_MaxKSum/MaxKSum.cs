using System;

namespace _06_MaxKSum
{
    /*Problem 6. Maximal K sum

    Write a program that reads two integer numbers N and K and an array of N elements from the console.
    Find in the array those K elements that have maximal sum.
                                                                        */
    class MaxKSum
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("You gotta enter the numbers for your array, separated by a space, pal");
                string[] firstArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);   //User inputs entire array. This is significantly more comfortable than first entering "N", and then "N" numbers on "N" lines
                string kValidator = Console.ReadLine();   //This is K

                int kNumber = 0;

                if (int.TryParse(kValidator, out kNumber) && kNumber < firstArray.Length)   //First comes validation for K. K is checked for non-numeric elements and if it goes out of index space
                {
                    int validator = 0;
                    int[] numberArray = new int[firstArray.Length];     //We declare a new aray that will hold all integers

                    for (int i = 0; i < firstArray.Length - 1; i++)     //We start scanning the array for non-numeric elements to ignore and add all integers to the new array
                    {//Hey, if you can think of a better way to do this, please tell me. I tried with clone and copy and they just didn't work for a string-->int array :( Maybe my syntax was wrong?
                        if (int.TryParse(firstArray[i], out validator))
                        {
                            numberArray[i] = validator;
                        }
                        else
                        {
                            Console.WriteLine("Element " + firstArray[i] + " isn't an integer, huh? Well waddaya know, I guess I won't use that!");    //Error message appears if non-integer element is found. The element is excluded from final results
                            //No need to add multiple error messages depending on error count
                        }
                    }

                    Array.Sort(numberArray);        //First, we sort the now completely numeric array. Internal algorithm-->Quicksort. Sorting is slow. Need to find better way.
                    Array.Reverse(numberArray);     //Now we invert it so that largest numbers are in the first indexes. Here's the reasoning: Why use a WriteLine(Array[Array.length-i-1]) when we can use WriteLine(Array[i]) instead?

                    int sumVar = 0;                 //Will later keep sum of resulted numbers
                    Console.Write("\nResults are: ");
                    for (int i = 0; i < kNumber; i++)
                    {
                        Console.Write(numberArray[i] + ", ");   //Printing results
                        sumVar += numberArray[i];
                    }
                    Console.Write("for a total of: " + sumVar + "\n\n");    //Printing sum of resulted numbers

                }
                else
                {
                    Console.WriteLine("K input invalid. Please try again"); //In case user inputs an invalid value for K
                }
            }
        }
    }
}
