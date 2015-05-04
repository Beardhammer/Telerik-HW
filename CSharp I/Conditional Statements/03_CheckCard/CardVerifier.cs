using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _03_CheckCard
{
    /*Problem 3. Check for a Play Card

    Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:

character 	Valid card sign?
        5 	yes
        1 	no
        Q 	yes
        q 	no
        P 	no
       10 	yes
      500 	no                                              */
    class CardVerifier
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("User will now input all cards in their hand and separate them with space.\nDo not worry. This information will not be used for anything else...hue hue hue");
            while (true)                                 //Keeps program looping
            {
                string[] userInputArray = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);  //User input is saved in this array
                string validCards = "-->";      //Will later save all valid cards
                string invalidCards = "-->";    //Will later save all invalid cards
                Console.WriteLine("\n");        //Just an empty line. Couldn't figure out a better way to do it
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                foreach (string verifyInput in userInputArray)   //Starts loop for each member of the array, which the user has input to
                {
                    byte card;      //Will hold cards with numeric value
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    if (byte.TryParse(verifyInput, out card) && card>1 && card<11)      //Numeric cards are checked
                    {
                        Console.WriteLine("Element \"" + verifyInput + "\" is a card"); //Prints that card is valid
                        validCards = validCards + " " + verifyInput;                    //Card is added to string
                    }
                    else if (verifyInput.Length<2 && !verifyInput.Except("JQKA").Any()) //Non-numeric cards are checked
                    {
                        Console.WriteLine("Element \"" + verifyInput + "\" is a card"); //Prints that card is valid 
                        validCards = validCards + " " + verifyInput;                    //Card is added to string
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    else                //Case card is invalid
                    {
                        Console.WriteLine("Element \"" + verifyInput + "\" is not a card");  //Prints that card is invalid
                        invalidCards = invalidCards + " " + verifyInput;                     //Card is added to different string
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
                Console.WriteLine("\nValid cards in your hand are are: "+validCards);   //Prints all valid elements
                Console.WriteLine("\nInvalid cards in your hand are are: " + invalidCards + "\n\nDo you want to enter another hand?");   //Prints all invalid elements

            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
