using System;
using System.Threading;
using System.Globalization;

namespace _09_ExchangeVarData   //09-Exchanges values between 2 int vars. I could not find any stable way of doing this outside of using a third var or the XOR method, which I'd rather not use at this point
{                      
    /*  Problem 9. Exchange Variable Values

    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
    Print the variable values before and after the exchange.    */

    class Program
    {

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int a = 5;
            int b = 10;
            Console.WriteLine("Before exchange:\na: " + a + ", b: " + b + "\nPress any key to swap their values.");
            Console.ReadKey();

            float Exchange = b;  //Temp int var to facilitate the exchange
            b= a;
            a = Convert.ToInt32(Exchange);
            Console.WriteLine("\nAfter exchange:\na: " + a + ", b: " + b);    //Prints values after exchange
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 1; i <= 50000; i++)
            {
                Console.WriteLine("\nDo you want swap 2 other values?\n");
                Console.Write("What's the first value gonna be?: ");
                float userInputIntTrue;    //Used in exchange. First valid value user inputs
                string userInputCheck = Console.ReadLine();    //Used in input validation
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (float.TryParse(userInputCheck, out userInputIntTrue))
                {
                    Console.Write("What about the second value?: ");
                    float userInputIntTrue2;    //Used in exchange. Second valid value user inputs
                    string userInputCheck2 = Console.ReadLine();    //Used in input validatio
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    if (float.TryParse(userInputCheck2, out userInputIntTrue2))
                    {
                        Console.WriteLine("Right now the values are\na: " + userInputIntTrue + ", b: " + userInputIntTrue2);
                        //The next 3 lines are where the magic happens
                        Exchange = userInputIntTrue2;
                        userInputIntTrue2 = userInputIntTrue;
                        userInputIntTrue = Exchange;

                        Console.WriteLine("\nAbra-cadabra and now they're\na: " + userInputIntTrue +", b: " + userInputIntTrue2 + "\nMagic is awesome, huh?");
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    else 
                    {
                        Console.WriteLine("\nWell, atleast one is a number...");    //Error message in case second value is invalid
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
                else
                {
                    Console.WriteLine("\nValues were supposed to be in NORMAL NUMBERS");    //In case first value is invalid
                }
               
            }//End For

        }
    }
}
