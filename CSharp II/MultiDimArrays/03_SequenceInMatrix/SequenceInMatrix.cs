using System;

namespace _03_SequenceInMatrix
{
    /*
     Problem 3. Sequence n matrix

    We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
    Write a program that finds the longest sequence of equal strings in the matrix.

Example:
//Example results are unreadable here. Just open the problems page in GitHub                     */
    class SequenceInMatrix
    {
        private static void Main()  //It works completely fine with strings if you need to use it that way. I just though numbers would be easier for the user ti inspect. Coding was done to be completely compatible with either with any size and proportion matrix
        {
            int[,] numberArray = new int[10,10];//Creating array of specified size

            for (int rows = 0; rows < numberArray.GetLength(0); rows++) //Populating array. I suppose you wouldn't wanna do it yourself, huh? Yeah, I don't blame ya
            {
                for (int cols = 0; cols < numberArray.GetLength(0); cols++)
                {
                    numberArray[rows, cols] = rows + cols
                }
            }

            //new int[5, 5]
            //{
            //    {00,03,01,01,00},
            //    {00,00,01,00,01},
            //    {00,00,00,00,10},
            //    {10,00,01,00,01},
            //    {00,03,01,01,50},
             
            //};
            Console.WriteLine("\nYour current matrix:\n");
            //Printing current matrix, so user can make sure output is correct
            for (int i = 0; i < numberArray.GetLength(0); i++)
            {
                for (int j = 0; j < numberArray.GetLength(1); j++)
                {
                    Console.Write(numberArray[i, j].ToString("00") + " ");
                    //Printing with extra space for larger numbers
                }
                Console.WriteLine();
            }

            int timesFound = 0;
            int maxTimesFound = 0;
            string itemFound = string.Empty;

            //Whyd did I make it return a value? Now that I look at it, I just wonder what I was thinking
            timesFound = VerticalSearch(numberArray, timesFound, ref maxTimesFound, ref itemFound);     //Normal
            timesFound = HorizontalSearch(numberArray, timesFound, ref maxTimesFound, ref itemFound);   //Normal
            timesFound = DiagonalRightSearch(numberArray, timesFound, ref maxTimesFound, ref itemFound);//Normal
            timesFound = DiagonalLeftSearch(numberArray, timesFound, ref maxTimesFound, ref itemFound); //Normal->2 hours spent fixing it. Problem ended up being a missing ref, which didn't even give me a compilation error! Wtf c#?!

            Console.WriteLine(itemFound + " has been found " + (maxTimesFound + 1) + " times"); //number
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        private static int DiagonalLeftSearch(int[,] numberArray, int timesFound, ref int maxTimesFound, ref string itemFound)
        {
            timesFound = 0; //Probably useless, but I don't have the time to check
            int ix = 0;
            for (int i = numberArray.GetLength(0) - 1; i>=0; i--)
            {
                ix = i;
                for (int j = 0; j < numberArray.GetLength(1) && ix > 0; j++, ix--)
                {
                    if (numberArray[j, ix] == numberArray[j + 1, ix - 1])
                    {
                        timesFound++;
                        if (timesFound > maxTimesFound) //">" --> first    ">=" --> last. Perf difference is medium between them
                        {
                            maxTimesFound = timesFound;
                            itemFound = numberArray[j, ix].ToString() + "(Diagonal left)";
                        }
                    }
                    else
                    {
                        timesFound = 0;
                    }
                }
                timesFound = 0;
            }
            return timesFound;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        private static int DiagonalRightSearch(int[,] numberArray, int timesFound, ref int maxTimesFound, ref string itemFound)
        {
            int ix = 0;
            for (int i = 0; i < numberArray.GetLength(1) - 1; i++)
            {
                ix = i;
                for (int j = 0; j < numberArray.GetLength(0) - 1 && ix < numberArray.GetLength(1) - 1; j++, ix++)
                {
                    if (numberArray[j, ix] == numberArray[j + 1, ix + 1])
                    {
                        timesFound++;
                        if (timesFound > maxTimesFound) //">" --> first    ">=" --> last
                        {
                            maxTimesFound = timesFound;
                            itemFound = numberArray[j, ix].ToString() + "(Diagonal, right)";
                        }
                    }
                    else
                    {
                        timesFound = 0;
                    }
                }
                timesFound = 0;
            }
            return timesFound;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        private static int VerticalSearch(int[,] numberArray, int timesFound, ref int maxTimesFound, ref string itemFound)
        {
            for (int i = 0; i < numberArray.GetLength(1); i++)
            {
                for (int j = 0; j < numberArray.GetLength(0) - 1; j++)
                {
                    if (numberArray[j, i] == numberArray[j + 1, i])
                    {
                        timesFound++;
                        if (timesFound > maxTimesFound) //">" --> first    ">=" --> last
                        {
                            maxTimesFound = timesFound;
                            itemFound = numberArray[j, i].ToString() + "(vertical)";
                        }
                    }
                    else
                    {
                        timesFound = 0;
                    }
                }
                timesFound = 0;
            }
            return timesFound;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        private static int HorizontalSearch(int[,] numberArray, int timesFound, ref int maxTimesFound, ref string itemFound)
        {
            for (int i = 0; i < numberArray.GetLength(0); i++)
            {
                for (int j = 0; j < numberArray.GetLength(1) - 1; j++)
                {
                    if (numberArray[i, j] == numberArray[i, j + 1])
                    {
                        timesFound++;
                        if (timesFound > maxTimesFound) //">" --> first    ">=" --> last
                        {
                            maxTimesFound = timesFound;
                            itemFound = numberArray[i, j].ToString()+"(horizontal)";
                        }
                    }
                    else
                    {
                        timesFound = 0;
                    }
                }
                timesFound = 0;
            }
            return timesFound;
        }
    }
}
