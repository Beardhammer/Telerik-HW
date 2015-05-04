using System;
using System.Speech.Synthesis;

namespace _02_MaxSum
{
    /*
     Problem 2. Maximal sum

    Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
                                        */
    class MaxSumFinder
    {
        static void Main()
        {
            var voiceSynth = new SpeechSynthesizer();
            while (true)
            {
                Console.Write("Please enter the size of the matrix we will be searching in\nNote: It fills up automatically, so you don't have to input anything :)\n-->");
                string matrixSizeVal = Console.ReadLine();
                int matrixSize = 0;

                Console.Write("Please enter the horizontal size of the square of numbers we are looking for:\n-->");
                string seekingRows = Console.ReadLine();
                int seekRows = 0;

                Console.Write("Please enter its verical size now:\n-->");
                string seekingColumns = Console.ReadLine();
                int seekCols = 0;

                if (int.TryParse(seekingColumns, out seekCols) && int.TryParse(seekingRows, out seekRows) &&
                    int.TryParse(matrixSizeVal, out matrixSize))    //Checking user input for non-numeric elements
                {

                    int[,] numberArray = new int[matrixSize, matrixSize];   //Creating array of specified size

                    for (int row = 0; row < matrixSize; row++)    //Populating array. I suppose you wouldn't wanna do it yourself, huh? Yeah, I don't blame ya
                    {
                        for (int col = 0; col < matrixSize; col++)
                        {
                            numberArray[row, col] = row + col;
                        }
                    }

                    Console.WriteLine("\nYour current matrix:\n");  //Printing current matrix, so user can make sure output is correct
                    for (int i = 0; i < numberArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < numberArray.GetLength(0); j++)
                        {
                            Console.Write(numberArray[i, j].ToString("00") + " ");  //Printing with extra space for larger numbers
                        }
                        Console.WriteLine();
                    }

                    var largestFoundSum = SumFinder(numberArray, seekRows, seekCols);   //Method finds quadliteral of largest sum

                    Console.WriteLine("\nYour result -->" + largestFoundSum + "\n\nWanna try again?\n");    //Printing result. Numbers used are not printed because of HUGE performance cost of recording them. Plus they're unneeded anyway
                    voiceSynth.Speak("Your result is  " + largestFoundSum);     //Stating result
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");   //Case user inputs bullshit
                }
            }

        }

        private static int SumFinder(int[,] numberArray, int seekRows, int seekCols)
        {
            int largestFoundSum = 0;
            int maxSumFinder = 0;       //Declaring it inside a loops is pointless

            for (int row = 0; row < numberArray.GetLength(0); row++)  //This part scans the entire matrix
            {
                for (int col = 0; col < numberArray.GetLength(0); col++)
                {
                    maxSumFinder = 0;
                    //Number scanner
                    for (int k = 0; k < seekRows && k + row < numberArray.GetLength(0); k++)  //This part finds and checks the sum of the current numbers and compares it to the largest one found
                    {//I hate hard-coding what can be done differently. Performance loss with this method --> very large --> ~440ms becomes ~700ms every 1 000 000 loops

                        for (int l = 0; l < seekCols && l + col < numberArray.GetLength(0); l++)
                        {
                            maxSumFinder += numberArray[row + k, col + l];
                        }
                    }
                    if (maxSumFinder >= largestFoundSum)    //If current sum is bigger than biggest found so far, biggest found so far becomes current sum
                    {
                        largestFoundSum = maxSumFinder;
                    }
                }
            }
            return largestFoundSum;     //Returning result of calculations
        }
    }
}
