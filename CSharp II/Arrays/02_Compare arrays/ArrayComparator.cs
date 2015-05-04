using System;

namespace _02_Compare_arrays
{
    /*Problem 2. Compare arrays

    Write a program that reads two integer arrays from the console and compares them element by element.

                                        */

    internal class ArrayComparator  //I couldn't understand what to do, so I give you two variations. Please choose the one you think is appropriate and ignore the other one
    {
        private static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please choose your mode, sir\n1-->Performs a simple check whether both arrays are equal or not\n2-->A more complex check inculding a comparison of every element index by index");
                string userYesNo = Console.ReadLine();
                if (userYesNo == "2")       //This version checks the arrays element by element and compares all elements which have the same index in both arrays(meaning it compares array1[x] with array2[x])
                {                       
                    Version2();
                }
                else if (userYesNo == "1")  //This version just checks whether the arrays are equal or not, but was supposed to work faster and use less memory
                                            //--> Well, it doesn't. Memory usage, execution, and compilation speeds are almost identical, with this one being faster 
                                            //only on non-identical arrays.V2 being slightly FASTER once every several hundred thousand executions for most things overall
                {
                    Version1();
                }
                else
                {
                    Console.WriteLine("Invalid input. Doth thee want to try again?");   //Case input is invalid
                }
            }
        }

        private static void Version1()  //First version I made
        {
            Console.WriteLine("Sir, Please enter the numbers for your first array, separated by a space");
            string[] firstArray = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Now please enter the numbers for your second array in the same manner");
            string[] secondArray = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);    //User inputs data for both arrays

            bool areTheyEqual = false;

            if (firstArray.Length == secondArray.Length)
            {
                areTheyEqual = true;
                for (var i = 0; i < firstArray.Length; i++)     //Math.Min(firstArray.Length, secondArray.Length) unneeded. Program will "break;" if both arrays aren't of equal size before even trying to compare anything
                {
                    int inputValidation;
                    if (!int.TryParse(firstArray[i], out inputValidation) || !int.TryParse(secondArray[i], out inputValidation))    //Little bit of optimisation here. If you want to scan for strings instead, please feel free to just remove this "if" block
                    {
                        Console.WriteLine("Non-integer element detected! Scanning stopped.");
                        Console.WriteLine("Element: " + firstArray[i] + " or/and element: " + secondArray[i] + " is not an integer!");
                        areTheyEqual = false;
                        break;
                    }
                    if (firstArray[i] != secondArray[i])    //Breaks if non-equal elements are found. Universalized to work for non-numeric input as well with little modification
                    {
                        areTheyEqual = false;
                        break;
                    }
                }
            }
            Console.Write("are they equal?-->" + areTheyEqual); //States whether both arrays are equal or not
            Console.WriteLine();
        }

        private static void Version2()  //Second version. I made this when I thought I misunderstood the assignment, though after finding out that version 1 is perfectly fine,
        {                               // I found no reason to delete this, so I decided to experiment a bit with methods while I'm at it

            Console.WriteLine("Sir, Please enter the numbers for your first array, separated by a space");
            string[] firstArray = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Now please enter the numbers for your second array in the same manner\nNote: I will stop comparing if a non-int element is found! Beware!");
            string[] secondArray = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);    //User inputs data for both arrays

            for (var i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                int num1;   //Should I have put these outside the loop or was leaving them here the better choice? What do you think?
                int num2;

                if (int.TryParse(firstArray[i], out num1) && int.TryParse(secondArray[i], out num2))
                {
                    if (num1 != num2)
                    {
                        Console.WriteLine(Math.Max(num1, num2) + " > " + Math.Min(num1, num2));     //States which element is bigger(index by index)
                    }
                    else
                    {
                        Console.WriteLine(num1 + " = " + num2);     //Case both elements are equal
                    }
                }
                else
                {
                    Console.WriteLine("Element: " + firstArray[i] + " or/and element: " + secondArray[i] + " is not an integer! I warned you!");      //Case parse is unsuccessful
                }
            }
        }
    }
}
