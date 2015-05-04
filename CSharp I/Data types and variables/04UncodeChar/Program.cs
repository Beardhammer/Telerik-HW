using System;

namespace _04UncodeChar
{
    /*  Problem 4. Unicode Character

    Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.

Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be "*".   */

    class Program   //More notes: Please excuse any mistaken terms or errors in program logic. I'm still new here and I have no idea what I'm doing ESPECIALLY when it comes to these Unicode and ASCII table thingies.
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            char code42='\u002A';
            Console.WriteLine(code42);              //Just prints character that corresponds with number 42 in Unicode
            Console.WriteLine("Want to party up with some cool Unicode characters?\nThen write \"party\", though if you bo-ring rite no");
            for (int i=1; i<=50000; i++)            //Start of loop to avoid unexpexted or unneeded shutdown
            {
            string userAnswer=Console.ReadLine();   //Either yes or no. On no, program exits
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
            if (userAnswer=="yes")
            {
                Console.WriteLine("Then say, good sir or madame, may I ask what the character on your mind is?\nNote: You may turn Unicode into numbers and numbers into Unicode. Have fun :)");
                for (int e = 1; e <= 50000; e++)    //Loop is used for input validation
                {
                    string userInputValidation=Console.ReadLine();
                    int intChar; 
//------------------------------------------------------------------------------------------------------------------------------------------------------------------                    
                            if (int.TryParse(userInputValidation, out intChar))   //Need to find way to deal with overflow
                            {
                                if (intChar < 65535)
                                {
                                    //On valid numeric input, character corresponding to entered number is printed
                                    Console.WriteLine("The value you input stands for the character: " + Convert.ToChar(intChar));
                                }
                                else
                                {
                                    //On invalid input, error message is shown
                                    Console.WriteLine("Mate, please enter only numbers(numbers up to 65535 are acceptable)");
                                }
                            }
                            else if (userInputValidation.Length==1)
                            {   
                                //On valid char input, number corresponding to char is printed
                                char userChar = Convert.ToChar(userInputValidation);
                                Console.WriteLine("The value of the key you pressed is: " + Convert.ToInt32(userChar));    
                            }
                            else
                            {
                                //On invalid input, error message is shown
                                Console.WriteLine("Mate, please enter only valid characters or numbers");                        
                            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }

            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
            else if(userAnswer=="no")   //Console exits if user input is no
            {
                System.Environment.Exit(1);
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
            else 
            {
                    if (i<10)
                    {
                        Console.WriteLine("please try again");  //On invalid input, error message is shown
                    }
                    else 
                    { 
                        Console.WriteLine("Mate, either your keyboard is broken or I have some bad news for you....");  //Console gets annoyed on invalid input. Please don't anger the console.
                    }
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
            }
        }
    }
}
