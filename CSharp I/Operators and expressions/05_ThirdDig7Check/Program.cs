


    /*Console.WriteLine(
                            "Which position do you want me to check? Leave me empty for default(3rd from right to left)");
                        string positionValidator = Console.ReadLine();
                        int userChosenPosition = inputValidator.Length - 3;

                        if (int.TryParse(positionValidator, out userChosenPosition))
                        {
                            if (userChosenPosition > 0 & userChosenPosition < inputValidator.Length)
                            {
                                Console.WriteLine("Which symbol shall I search for?");
                                string symbolValidator = Convert.ToString(Console.Read());
                                int symbolContainer;
                                if (int.TryParse(symbolValidator, out symbolContainer))
                                {
                                    var checkPositionValue = inputValidator.Substring(userChosenPosition - 1, 1);
                                    if (checkPositionValue == symbolValidator)
                                    {
                                        Console.WriteLine("Your number contains a 7 at position " + userChosenPosition);
                                        Console.WriteLine("\nDo you want to try another number?");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The number at the specified position is " +
                                                          checkPositionValue + ", not " + symbolValidator);
                                        Console.WriteLine("\nDo you want to try another number?");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Damn it, Ivan, you digits are too few!");
                            }
                        }
                        else if (string.IsNullOrEmpty(positionValidator) & inputValidator.Length > 2)
                        {
                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please try again");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please try again");
                    }
                }
                else
                {
                    
                }
            }






            /* var userInputValidator = Console.ReadLine();   //Number is input by user
                int userInputInt;

                if (int.TryParse(userInputValidator, out userInputInt))   //Parsing check
                {

                Console.Write("Which position do you want to check? Leave empty to use default value(3rd from right to left)");
                String userPositionToCheckValidator=Console.ReadLine();     //Input by user
                int userPositionToCheck=userInputValidator.Length-3; 

                if (int.TryParse(userPositionToCheckValidator, out userPositionToCheck))
                {
                        string userInputParsed = Convert.ToString(userInputInt);
                        int userInputLength = userInputParsed.Length;

                        if (userInputLength < 3)
                        {
                            Console.WriteLine("Your input is less than 3 digits! Please retry.");
                        }
                        else
                        {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            var checkPositionValue = userInputParsed.Substring(userPositionToCheck, 1);
                            if (checkPositionValue == "7")
                            {
                                Console.WriteLine("Your number contains a 7 at position " + (userInputLength - 2));
                            }
                            else
                            {
                                Console.WriteLine("The number at the specified position is " + checkPositionValue +
                                                  ", not 7");
                            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please retry. ");
                    }
                }
                else
                {
                    Console.WriteLine("Parse unsuccessful. What the hell did you write?...");
                }
                Console.WriteLine("Do you want to check another number?");
            } //End For*/
     

//------------------------------------------------------------------------------------------------------------------------------------------------------------------
