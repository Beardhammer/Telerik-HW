using System;

namespace _05_Check7
{
    /*Problem 5. Third Digit is 7?

        Write an expression that checks for given integer if its third digit from right-to-left is 7.

    Examples:
    n 	Third digit 7?
    5 	false
    701 	true
    9703 	true
    877 	false
    777877 	false
    9999799 	true                */
    class Program   //Finish it
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(
                "Shall I execute problem 05 and search for a 7\n...Or should I search for any symbol in any position?y/i(meaning: yes/index)");
            string userYesNo = Console.ReadLine();
            for (var forCycleVar = 1; forCycleVar <= 50000; forCycleVar++)
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (userYesNo == "y")
                {
                    Console.WriteLine("What is your number ,.... Master?");
                    String inputValidator = Console.ReadLine();
                    int userNumberForCheck;

                    if (int.TryParse(inputValidator, out userNumberForCheck))
                    {
                        var checkPositionValue = inputValidator.Substring(inputValidator.Length - 3, 1);

                        if (checkPositionValue == "7")
                        {
                            Console.WriteLine("Your number contains a 7 at position " + (inputValidator.Length - 2));
                        }
                        else
                        {
                            Console.WriteLine("The number at the specified default position is " + checkPositionValue +
                                              ", not 7");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your input is invalid");
                    }
                }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else if (userYesNo == "i")
                {
                    Console.WriteLine("What is your string ,.... Master?");
                    string userInputString = Console.ReadLine();
                    Console.WriteLine("What is your position?");
                    string userPositionValidator = Console.ReadLine();
                    int userPosition;
                    if (int.TryParse(userPositionValidator, out userPosition))
                    {
                        if (!string.IsNullOrWhiteSpace(userPositionValidator) & userPosition >= 0 &
                            userPosition < userInputString.Length)
                        {
                            Console.WriteLine("What symbol are we searching for?");
                            string chosenSymbol = Console.ReadLine();

                            var chosenSymbolCheck = userInputString.Substring(userPosition - 1, 1);
                            if (chosenSymbolCheck == chosenSymbol)
                            {
                                Console.WriteLine("Your string contains " + chosenSymbol + " at position " +
                                                  userPosition);
                            }
                            else
                            {
                                Console.WriteLine("The symbol at the specified position is " + chosenSymbolCheck + ", not " + chosenSymbol);

                            }
                        }
                        else
                            {
                                Console.Write("Invalid input. Please try agan");
                            }
                        }
                        else
                        {
                            Console.WriteLine("invalid position!");
                        }

                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                Console.WriteLine("\nTry another one?y/i");
                userYesNo = Console.ReadLine();
                }
            }
        }
    }

      