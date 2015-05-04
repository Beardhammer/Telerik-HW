using System;

namespace _06_The_Concatenator  //06-The Concatenator declares 2 strings and assigns them "hello" and "world" respectively, 
{                                    //then it declares an object and assigns it with the concatenation of those two strings
    /*  Problem 6. Strings and Objects

    Declare two string variables and assign them with Hello and World.
    Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
    Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).  */

    class Program
    {
        static void Main(string[] args)    //Try to say "Hasta la vista", baby
        {
            string hello = "Hello";
            string World = "World";
            object helloWorld = hello + " " + World;               //Simple concatenation here
            string objHelloWorld =Convert.ToString(helloWorld);    //Just conversion of object to string
            Console.WriteLine("'Tis " + objHelloWorld);            //Prints the object type assigned with concatenation
//------------------------------End--Of--First--Block------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\nWant to try concatenating your own strings through an object type?\nTry today then!\nEnter the first string: ");
            for (int i = 1; i <= 50000; i++)                       //Loop keeps program running
            {
                string firstString = Console.ReadLine();           //First string input by user
                Console.WriteLine("\nNow enter the second string: ");
                string secondString = Console.ReadLine();          //Second string input by user
                object userConcatenation = firstString + " " + secondString;    //obj assigned with concatenation as described in problem 06
                Console.WriteLine(userConcatenation);              //Prints obj
                Console.WriteLine("Want to try again? It IS awesome after all!");
            }
        }
    }
}
