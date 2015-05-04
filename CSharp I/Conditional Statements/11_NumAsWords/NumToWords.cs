using System;

namespace _11_NumAsWords
{
    /*Problem 11.* Number as Words

    Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

Examples:
numbers 	number as words
0 	Zero
9 	Nine
10 	Ten
12 	Twelve
19 	Nineteen
25 	Twenty five
98 	Ninety eight
98 	Ninety eight
273 	Two hundred and seventy three
400 	Four hundred
501 	Five hundred and one
617 	Six hundred and seventeen
711 	Seven hundred and eleven
999 	Nine hundred and ninety nine                        */
    internal class NumToWords
    {
        private static void Main()
        {
            while (true)
            {
                    Console.Write("\nPlease enter a number between 999 and 0. \n");
                    var userNumValidator = (Console.ReadLine());
                    int userNum = 0;
                
                    var hundreds = 0;
                    var tens = 0;
                    var ones = 0;

                if (int.TryParse(userNumValidator,out userNum)) //Checks number for non-parsable elements
                {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    if (userNum > 99)   //Case number is 3 digits
                    {
                        hundreds = userNum/100;
                        switch (hundreds)
                        {
                            case 1:
                                Console.Write("One-hundred");
                                break;
                            case 2:
                                Console.Write("Two-hundred");
                                break;
                            case 3:
                                Console.Write("Three-hundred");
                                break;
                            case 4:
                                Console.Write("Four-hundred");
                                break;
                            case 5:
                                Console.Write("Five-hundred");
                                break;
                            case 6:
                                Console.Write("Six-hundred");
                                break;
                            case 7:
                                Console.Write("Seven-hundred");
                                break;
                            case 8:
                                Console.Write("Eight-hundred");
                                break;
                            case 9:
                                Console.Write("Nine-hundred");
                                break;
                        }
                        if (userNum%100 != 0)   //Subcase number doesn't end in 00
                        {
                            Console.Write("-and-");
                        }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    }
                    if ((userNum%100) > 19)     //Case number is less than 100
                    {
                        tens = (userNum%100)/10;
                        switch (tens)
                        {
                            case 2:
                                Console.Write("twenty-");
                                break;
                            case 3:
                                Console.Write("thirty-");
                                break;
                            case 4:
                                Console.Write("forty-");
                                break;
                            case 5:
                                Console.Write("fifthy-");
                                break;
                            case 6:
                                Console.Write("sixty-");
                                break;
                            case 7:
                                Console.Write("seventy-");
                                break;
                            case 8:
                                Console.Write("eighty-");
                                break;
                            case 9:
                                Console.Write("ninety");
                                break;
                        }
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    if (((userNum%100) < 10) || ((userNum%100) > 19))   //Case number is single digit
                    {
                        ones = userNum%10;
                        switch (ones)
                        {
                            case 1:
                                Console.Write("one");
                                break;
                            case 2:
                                Console.Write("two");
                                break;
                            case 3:
                                Console.Write("three");
                                break;
                            case 4:
                                Console.Write("four");
                                break;
                            case 5:
                                Console.Write("five");
                                break;
                            case 6:
                                Console.Write("six");
                                break;
                            case 7:
                                Console.Write("seven");
                                break;
                            case 8:
                                Console.Write("eight");
                                break;
                            case 9:
                                Console.Write("nine");
                                break;
                        }
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    else    //Case number is 2 digits
                    {
                        tens = userNum%100; 
                        switch (tens)
                        {
                            case 10:
                                Console.WriteLine("ten");
                                break;
                            case 11:
                                Console.WriteLine("eleven");
                                break;
                            case 12:
                                Console.WriteLine("twelve");
                                break;
                            case 13:
                                Console.WriteLine("thirteen");
                                break;
                            case 14:
                                Console.WriteLine("fourteen");
                                break;
                            case 15:
                                Console.WriteLine("fifteen");
                                break;
                            case 16:
                                Console.WriteLine("sixteen");
                                break;
                            case 17:
                                Console.WriteLine("seventeen");
                                break;
                            case 18:
                                Console.WriteLine("eighteen");
                                break;
                            case 19:
                                Console.WriteLine("nineteen");
                                break;
                        }
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    if (userNum == 0)   //Case number is 0
                    {
                        Console.WriteLine("Zero");
                    }
                }
            }
        }
    }
}
