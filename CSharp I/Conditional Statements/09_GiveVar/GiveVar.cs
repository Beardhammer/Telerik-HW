using System;
using System.Globalization;
using System.Threading;

namespace _09_GiveVar
{
    /*Problem 9. Play with Int, Double and String

    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        If the variable is int or double, the program increases it by one.
        If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.

Example 1:
program 	user
Please choose a type: 	
1 --> int 	
2 --> double 	
3 --> string 	3
	
Please enter a string: 	hello
	
hello* 	

Example 2:
program 	user
Please choose a type: 	
1 --> int 	
2 --> double 	2
3 --> string 	
	
Please enter a double: 	1.5
	
2.5 	                                            */
    class GiveVar
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)
            {
                Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
                string inputAction = Console.ReadLine();    //User chooses type of var for input

                string userString = ""; //Nulled everything just in case
                int userInt = 0;
                double userDouble = 0;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                switch (inputAction)
                {
                    case "1":
                        Console.WriteLine("Please enter an integer: ");
                        userString = Console.ReadLine();
                        userInt=0;
                        if (int.TryParse(userString, out userInt))  //Checks whether user has actually input and int or not
                        {
                            Console.WriteLine("Your integer is now: " + (userInt + 1)); //Prints input number + 1
                        }
                        else
                        {
                            Console.WriteLine("Your integer is invalid, mate...."); //Case input could not be parsed
                        }
                        break;
                    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    case "2": 
                        Console.WriteLine("Please enter a double: ");
                        userString = Console.ReadLine();
                        userDouble = 0;
                        if (double.TryParse(userString, out userDouble))  //Checks whether user has actually input a double or not
                        {
                            Console.WriteLine("Your double is now: " + (userDouble + 1)); //Prints input number + 1
                        }
                        else
                        {
                            Console.WriteLine("Your integer is invalid, mate...."); //Case input could not be parsed
                        }
                        break;
                    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    case "3":
                        Console.WriteLine("Please enter a string: ");
                        userString = Console.ReadLine();
                        Console.WriteLine("Your string is now: " + userString + "*"); //Prints input string + "*"
                        break;
                    default:    
                        Console.WriteLine("Yo input is invalid, mate!");    //Case code for chosen action is not 1-3
                        break;
                }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("\nWanna try again?\n");  //Program loops here
            }
        }
    }
}
