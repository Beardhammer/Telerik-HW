using System;

namespace _10_OddEvenProd
{
    /*Problem 10. Odd and Even Product

    You are given n integers (given in a single line, separated by a space).
    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
    Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

Examples:
numbers 	result
2 1 1 6 3 	yes
product = 6 	
	
3 10 4 6 5 1 	yes
product = 60 	
	
4 3 2 5 2 	no
odd_product = 16 	
even_product = 15 	                        */
    class OddEvenProd
    {
        static void Main()
        {
            while (true)
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("Enter your numbers on a single line, saparated by space...");
                string[] userInput =Console.ReadLine().Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries);  //User inputs here

                double sumOdd = 1;
                double sumEven = 1;
                double currentNumber = 1;
                int index = 1;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                foreach (string number in userInput)    //Checks each element
                {
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    if (double.TryParse(number, out currentNumber)) //Whether or not it is numeric
                    {
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        index++;
                        if (index%2 == 0)
                        {
                            sumEven *= currentNumber;
                        }
                        else if (index%2 != 0)
                        {
                            sumOdd *= currentNumber;
                        }
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    }
                }
                bool result = sumEven == sumOdd;
                Console.WriteLine("\nAre their even and odd products equal?--> " + result); //Prints result
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
