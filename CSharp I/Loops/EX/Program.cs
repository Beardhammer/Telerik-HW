using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want look at your cards, sir?");
            Console.ReadLine();
            for (int i = 1; i <= 8; i++)
            {
                    int xxx = System.Environment.TickCount + 50;
                    Random card = new Random();
                    int cardInHand = card.Next(1, 13);
                    switch (i)
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
                    Random type = new Random();
                    int typeInHand = type.Next(1, 4);
                    switch (typeInHand)
                    {
                        case 1:
                            Console.Write("Clubs, ");
                            break;
                        case 2:
                            Console.Write("Diamonds, ");
                            break;
                        case 3:
                            Console.Write("Hearts, ");
                            break;
                        case 4:
                            Console.Write("Spades, ");
                            break;
                        default:
                            Console.Write("Error");
                            break;
                    }
            }
        }
    }
}
