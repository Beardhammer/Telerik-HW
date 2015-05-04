using System;

namespace _03_CompCharArraysLex
{
    /*Problem 3. Compare char arrays

    Write a program that compares two char arrays lexicographically (letter by letter).
                                                                                                */
    class CharArrayCompareLex
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Senior, Please enter the characters for your first array");
                char[] firstArray = Console.ReadLine().ToCharArray();
                Console.WriteLine("now enter the characters for your second array");
                char[] SecondArray = Console.ReadLine().ToCharArray();  //User enters both char arrays

                bool areTheyEqual = true;           
                
                for (int i = 0; i < Math.Min(SecondArray.Length, firstArray.Length); i++)   //Runs through both arrays, looking for inequalities
                {
                    if (firstArray[i] != SecondArray[i])    //Case inequality found
                    {
                        if (firstArray[i] > SecondArray[i]) //In case first array is after second, line will be printed and loop will break
                        {
                            Console.WriteLine("Second array comes before the first one lexicographically");
                            areTheyEqual = false;
                            break;
                        }                                   //If first statement isn't true, then it won't execute(and therefore break :p) and this code will be executed instead
                        Console.WriteLine("First array comes before the second one lexicographically");
                            areTheyEqual = false;
                            break;  
                    }
                }
               
                if (firstArray.Length==SecondArray.Length && areTheyEqual)  //Case no inequalities are found and both arrays are of equal size
                {
                    Console.WriteLine("Senior, your char arrays are lexicographically equal!");

                }
                else if (areTheyEqual)                      //Case no inequalities are found, but arrays are of different size
                {
                    if (firstArray.Length > SecondArray.Length)
                    {
                        Console.WriteLine("Second array seems to come lexicographically before the first one...");     //Couldn't make up my mind where I should put the word "lexicographically"
                    }
                    else if (firstArray.Length < SecondArray.Length)
                    {
                        Console.WriteLine("First array most definitelly comes lexicographically before the second one!");
                    }
                }
            }
        }
    }
}
