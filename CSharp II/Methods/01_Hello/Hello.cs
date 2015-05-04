using System;

namespace _01_Hello
{
    /*Problem 1. Say Hello

    Write a method that asks the user for his name and prints “Hello, <name>”
    Write a program to test this method.

Example:
input 	output
Peter 	Hello, Peter!                       */
    class Hello
    {
        static void Main()
        {
            AskName();
        }

        static void AskName()
        {
            Console.WriteLine("Please enter yor name");
            string userName = Console.ReadLine();
            Console.WriteLine("Congratulations! Your name is " + userName + "\nHello " + userName + "!");
        }
    }
}
