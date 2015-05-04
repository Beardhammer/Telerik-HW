using System;
using System.Globalization;

namespace _13_SolveTasks
{
    /*
     Problem 13. Solve tasks

    Write a program that can solve these tasks:
        Reverses the digits of a number
        Calculates the average of a sequence of integers
        Solves a linear equation a * x + b = 0
    Create appropriate methods.
    Provide a simple text-based menu for the user to choose which task to solve.
    Validate the input data:
        The decimal number should be non-negative
        The sequence should not be empty
        a should not be equal to 0
                                                            */
    internal class SolveTasks
    {
        private static void Main()
        {
            while (true)
            {
                Console.Write("Which subroutine shall I, T-300, execute?\n" +
                              "1-->Lethal reversal of all digits in a number.\n" +
                              "The poor fuck'll never know what him 'im\n" +
                              "2-->Destructive display of calculative capabilities by calculating the average from a set of integers\n" +
                              "No turning back after this one!\n" +
                              "3-->Chaotic execution by answer of linear equations\n" +
                              "Completely irreversible!\n-->");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "2")
                {
                    Console.Write(
                        "Impressive courage! Nobody's chosen this....untill now. Well, atleast no survivors exit anyway\nI suggest you prepare yourself beforehand. Nobody's ever returned after this choice haha!\nY'know the rules, right? All your numbers on a single line. Separate them by space\n-->");
                    string[] numberArrayValidator = Console.ReadLine()
                        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                    if (numberArrayValidator.Length > 0)
                    {
                        int[] numberArray = new int[numberArrayValidator.Length];
                            //Whole block is array input validation
                        //{1,43,43,4,4,5,27,27,78,887,342,442,454,47,907};

                        int validator;
                        int indexer = 0;
                        foreach (var item in numberArrayValidator)
                        {
                            if (int.TryParse(item, out validator)) //Putting all numbers into new array
                            {
                                numberArray[indexer] = validator;
                                indexer++;
                            }
                        }
                        Array.Resize(ref numberArray, indexer); //End input validation

                        Console.WriteLine(
                            "Here's your array. Cleaned it up. A butcher's always gotta have clean knives after all, no?\n--> " +
                            String.Join(", ", numberArray) + "\n");
                        Console.WriteLine("Destru--err calculation COMPLETE. Your averaagee iis: ");
                        PrintSetAverage(numberArray);
                        //Showing user cleaned array
                    }
                }
                else if (userAnswer == "1")
                {
                    Console.Write(
                        "Great choice! I was in the mood for some....reversal haha! Enter away, it won't hurt....you\n-->");

                    string reverser = ReverseNumber(Console.ReadLine());
                    ulong validator = 0;

                    if (ulong.TryParse(reverser, out validator)) //Input validation
                    {
                        Console.WriteLine("Here's our number reversed. We won't be seeing it again. Ever haha! --> " +
                                          reverser);
                    }
                    else
                    {
                        Console.WriteLine(
                            "Error! Error! What the hell!?\nMake sure your input is completely numeric and NON-NEGATIVE next time!");
                    }
                }
                else if (userAnswer == "3")
                {
                    while (true)
                    {
                        string aVal = string.Empty;
                        string bVal = string.Empty;
                        string cVal = string.Empty;

                        Console.Write("Time to  enter a\n-->");
                        aVal = Console.ReadLine();

                        Console.Write("now enter b\n-->");
                        bVal = Console.ReadLine();

                        Console.Write("Enter c\n-->");
                        cVal = Console.ReadLine();

                        int a = 0;
                        int b = 0;
                        int c = 0;

                        if (int.TryParse(aVal, out a) && int.TryParse(bVal, out b) && int.TryParse(cVal, out c) &&
                            a != 0) //What decimal number? Hinestly, I didn't quite get that part
                        {
                            Console.WriteLine("Our victi--err equation is --> {0}*x+({1})={2}", a, b, c);
                                //Printing current equation
                            float result = SolveLinearEquation(a, b, c);
                            Console.WriteLine("Our x is --> " + result + "\n{0}*{1}+{2}={3}", a,
                                (result < 0 ? "(" + result + ")" : result.ToString()),
                                (b < 0 ? "(" + b.ToString() + ")" : b.ToString()), c);
                            //Printing solved equation and answer

                        }
                        else
                        {
                            Console.WriteLine("Goddamnit what didya input?! Try again NOW");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operation! Try again when sober!");
                }
            }

        }

        private static string ReverseNumber(string number) //No need for input validation
        {
            char[] characterArray = number.ToString(CultureInfo.InvariantCulture).ToCharArray();
            //Stringbuilder would be too slow here
            for (int i = 0; i < characterArray.Length / 2; i++)
            //Exchanges variables from both ends untill middle is reached
            {
                char temp = characterArray[i];
                characterArray[i] = characterArray[characterArray.Length - 1 - i];
                characterArray[characterArray.Length - 1 - i] = temp;
            }
            return string.Join("", characterArray);

        }
        static void PrintSetAverage(params int[] numberArray)   //Sums all numbers, then divides by their count
        {
            int average = 0;
            foreach (var item in numberArray)
            {
                average += item;
            }
            Console.WriteLine("Our average ist: " + average / (numberArray.Length>0?numberArray.Length:1)); //If Array.length is >0, then divide by it, otherwise divide by 1
        }

        static float SolveLinearEquation(int a, int b, int c)
        {
            float solveLeft = c - b;
            float result = solveLeft / a;
            return result;
        }
    }
}

