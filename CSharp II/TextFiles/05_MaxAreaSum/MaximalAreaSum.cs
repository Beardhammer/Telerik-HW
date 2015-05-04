using System;
using System.IO;
using System.Text;

namespace _05_MaxAreaSum
{
    /*Problem 5. Maximal area sum

    Write a program that reads a text file containing a square matrix of numbers.
    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
        The first line in the input file contains the size of matrix N.
        Each of the next N lines contain N numbers separated by space.
        The output should be a single number in a separate text file.

Example:
input 	output
4
2 3 3 4
0 2 3 4
3 7 1 2
4 3 3 2 	17                                              */
    class MaximalAreaSum
    {
        static void Main()
        {
            StreamReader fileReader = new StreamReader(@"..\..\..\OurMatrix.txt");
            StreamWriter resultPrinter = new StreamWriter(@"..\..\..\AreaSumResult.txt");

            //Actually, the matrix auto-detects its size in a sense, so I honestly don't see a use for this variable
            int size = int.Parse(fileReader.ReadLine());  //Didn't use input validation here. Program is supposed to crash on invalid input either way

            string firstLine = string.Empty;
            string secondLine = string.Empty;
            int result = 0;                                     //Will go through every sum
            int max = int.MinValue;                             //Will hold max sum
            StringBuilder resultLocation=new StringBuilder();   //Will hold result 2x2 max sum square


            //Basically, this is how it works:
            //First, we read a line, then we read another line, we get 2 consecutive numbers from both lines at current index and index+2 in order to skip spaces
            //Then we sum them, and compare them to the largest found sum. Any non-numeric elements at the spots where there should be numbers are treates as zeroes
            //Then we read another line and compare it to the second line(first lime becomes what second line was, while second line gets next line)
            //This goes on until we reach the end of the matrix

            firstLine = fileReader.ReadLine();
            using (fileReader)  //I suggest using productivity power tools for visual studio in order to make this program easier to read
            {
                while (fileReader.EndOfStream == false)  
                {
                    secondLine = fileReader.ReadLine();
                    if (firstLine == secondLine || string.IsNullOrWhiteSpace(secondLine)) break;
                    for (int numbers = 0; numbers + 2 < Math.Min(firstLine.Length, secondLine.Length); numbers += 2)
                    {
                        int firstNumFirstLine = 0;      //While re-declaring variables constantly DOES lower performance slightly, 
                        int firstNumSecondLine = 0;     //the several micro or even nanosecond difference 
                        int secondNumFirstLine = 0;     //is of no importance is such a simple program, so I went for a more readable approach instead
                        int secondNumSecondLine = 0;

                        int.TryParse(firstLine[numbers].ToString(), out firstNumFirstLine);     //Non-numeric elements are treated as zeroes
                        int.TryParse(secondLine[numbers].ToString(), out firstNumSecondLine);
                        int.TryParse(firstLine[numbers + 2].ToString(), out secondNumFirstLine);
                        int.TryParse(secondLine[numbers + 2].ToString(), out secondNumSecondLine);

                        result = firstNumFirstLine + firstNumSecondLine + secondNumFirstLine + secondNumSecondLine;

                        if (result > max)   //Not much to explain here
                        {
                            max = result;
                            resultLocation.Clear();
                            resultLocation.AppendLine("Location: ");
                            resultLocation.AppendLine(firstNumFirstLine +" "+ secondNumFirstLine);
                            resultLocation.AppendLine(firstNumSecondLine +" "+secondNumSecondLine);
                        }
                    }
                    firstLine = secondLine;
                }
            }

            using (resultPrinter)   //Prints final result to document
            {
                resultPrinter.WriteLine(max);
                resultPrinter.Write(resultLocation);
            }
        }
    }
}