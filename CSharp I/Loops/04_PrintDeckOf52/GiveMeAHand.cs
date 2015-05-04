using System;

namespace _04_PrintDeckOf52
{
    /*Problem 4. Print a Deck of 52 Cards

    Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
        The card faces should start from 2 to A.
        Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

output

2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
…  
K of spades, K of clubs, K of hearts, K of diamonds
A of spades, A of clubs, A of hearts, A of diamonds
*/
    class GiveMeAHand   //Note: I misunderstood the assignment. That's why I also have a program that prints a hand with 5 cards haha! *facepalm*
    {                  
        static void Main()
        {
            while (true)
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("\nDo you want to get be dealt a hand, or do you want to print all cards in order, sir? hand/order");
                string userYesNo = Console.ReadLine();          //User chooses what sectin to intialise
                if (userYesNo == "order")   //This part prints all cards combinations in order Aces-->Kings
                {
                    for (int i = 1; i <= 13; i++)   //Loops for every card. First we have a value i
                    {
                      
                        for (int e = 1; e <= 4; e++) //Also loops for every card. Now we also have a value e
                        {
                            //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            switch (i)  //Gets a new part 1 of a card and increases by one every cycle until <=13 
                            {
                                case 1:
                                    Console.Write("Ace of ");
                                    break;
                                case 11:
                                    Console.Write("Jack of ");
                                    break;
                                case 12:
                                    Console.Write("Queen of ");
                                    break;
                                case 13:
                                    Console.Write("King of ");
                                    break;
                                default:
                                    Console.Write(i + " of ");
                                    break;
                            }
                            //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            switch (e)  //Gets part 2 of a card and increases by one every cycle until <=4
                            {
                                case 1:
                                    Console.Write("\u2663, ");  //Black clubs
                                    break;
                                case 2:
                                    Console.Write("\u2666, ");  //Black diamonds
                                    break;
                                case 3:
                                    Console.Write("\u2665, ");  //Black hearts
                                    break;
                                case 4:
                                    Console.Write("\u2660, \n");    //Black spades
                                    break;
                                default:
                                    Console.Write("Error with \"e\"");     //Will most likely never happen
                                    break;
                            }
                        }
                    }
                }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else if (userYesNo=="hand")
                {                  
                    Console.WriteLine("The cards in your hand are: ");
               
                    for (int i = 1; i <= 5; i++)   //Repeats five times while rnd seed gets a card
                    {
                        Random card = new Random(Guid.NewGuid().GetHashCode()); //Difficult bit of code to write. tried with 3 seeds randomizing each other and pausing the thread for 20ms before I got here
                        int cardInHand = card.Next(1, 13);
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        switch (cardInHand)
                        {
                            case 1:
                                Console.Write("Ace of ");
                                break;
                            case 11:
                                Console.Write("Jack of ");
                                break;
                            case 12:
                                Console.Write("Queen of ");
                                break;
                            case 13:
                                Console.Write("King of ");
                                break;
                            default:
                                Console.Write(cardInHand + " of ");
                                break;
                        }
                        int typeInHand = card.Next(1, 4);
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        switch (typeInHand)
                        {
                            case 1:
                                Console.Write("\u2663, ");  //Black clubs
                                break;
                            case 2:
                                Console.Write("\u2666, ");  //Black diamonds
                                break;
                            case 3:
                                Console.Write("\u2665, ");  //Black hearts
                                break;
                            case 4:
                                Console.Write("\u2660, \n");    //Black spades
                                break;
                            default:
                                Console.Write("Error with random number!");     //Will most likely never happen
                                break;
                        }
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    }
                }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else
                {
                    Console.WriteLine("Zat ist nicht a command!!!!");   //Case user inputs gibberish
                }
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
