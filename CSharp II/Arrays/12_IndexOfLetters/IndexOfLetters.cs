using System;

namespace _12_IndexOfLetters
{
    /*Problem 12. Index of letters

    Write a program that creates an array containing all letters from the alphabet (A-Z).
    Read a word from the console and print the index of each of its letters in the array.
                                                            */
    class IndexOfLetters
    {
        static void Main()
        {
            Console.WriteLine("Please enter your words, sire");
            char[] userInput = Console.ReadLine().ToCharArray();

            char[] userAlphabetNoInput = new char[52];      //Creating array with all letters of the english alphabet
            for (int i = 0; i < 26; i++)//Populating first 26 positions with all UPPERCASE letters
            {
                userAlphabetNoInput[i] = (char)(i + 65);    //65-->A. Was this called casting?
            }
            for (int i = 26; i < 52; i++)//Populating last 26 positions with all lowercase letters
            {
                userAlphabetNoInput[i] = (char)(i + 71);    //71-->a
            }

            foreach (char currentLetter in userInput)   //PerfTest Results --> Negligible difference of for vs foreach. Foreach used for readibility advantage
            {
                int position = Array.IndexOf(userAlphabetNoInput, currentLetter);   //Getting position of current element

                if (currentLetter != ' ' && position>-1)   //Yes, it scans commas, full stops and so on. That's a feature, not a bug :p 
                {
                    Console.WriteLine("Your letter --> " + currentLetter + " is at index --> " + position);
                }
                else if (currentLetter != ' ' && position <= -1)
                {
                    Console.WriteLine("Your letter --> " + currentLetter + " has not been found");
                }
            }
        }
    }
}
