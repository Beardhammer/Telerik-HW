using System;

namespace _01_Allocate_Array
{
    /*Problem 1. Allocate array

    Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
    Print the obtained array on the console.
                                                    */
    class ArrayIndexBy5
    {
        static void Main()
        {
            int[] userInputArray = new int[20];          //Creates an array of size 20 units

            for (int i = 0; i < userInputArray.Length; i++)     
            {
                userInputArray[i] = i * 5;               //Element = index*5
            }
                Console.WriteLine("Any elements needed?\n--->" + String.Join(", ", userInputArray) + " :p");            //Prints every element of the array separately
        }
    }
}
