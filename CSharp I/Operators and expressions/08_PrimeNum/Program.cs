using System;

namespace _08_PrimeNum
{
    class Program
    {
        /*      Problem 8. Prime Number Check

    Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
    Note: You should check if the number is positive

Examples:
n 	Prime?
1 	false
2 	true
3 	true
4 	false
9 	false
97 	true
51 	false
-3 	false
0 	false   
                                                        */

        private static void Main(string[] args)
            //Yes, yes, I know this is the single worst method to find a prime number and that there are much simpler and faster algorhithms, but spare me now. It's 5 am and my head is spinning at this point. I'm barely making it in time!
        {
            Console.WriteLine("Please enter the number you wish me to check");
            for (var e = 1; e <= 50000; e++) //Keeps program looping
            {
                var userPrime = Convert.ToInt32(Console.ReadLine()); //gets user input
                var checker = 0; //Used in checking for prime numbers
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                for (var i = 1; i <= userPrime; i++) //used in division
                {
                    if (userPrime%i == 0) //Crudely divides the input number by every one below it
                    {
                        checker = checker + 1;
                            //Increases every time a successful division occurs. If value=2, then number is prime, otherwise the number isn't prime
                    }
                }
                if (checker == 2) //If value=2, then number is officially deemed prime
                {
                    Console.WriteLine("Thine number is a prime!");
                }
                else
                {
                    Console.Write("Thine number is not a prime!");
                }
                Console.WriteLine("Want to try another one?");
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
