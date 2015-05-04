using System;

namespace _02_BonusScore
{
    /*Problem 2. Bonus Score

Write a program that applies bonus score to given score in the range [1…9] by the following rules:
If the score is between 1 and 3, the program multiplies it by 10.
If the score is between 4 and 6, the program multiplies it by 100.
If the score is between 7 and 9, the program multiplies it by 1000.
If the score is 0 or more than 9, the program prints “invalid score”.
Examples:

score	result
2	20
4	400
9	9000
-1	invalid score
10	invalid score                   */
    class BonusScore
    {
        static void Main()
        {
            Console.WriteLine("User will now input their score");
            while (true)                //Keeps program looping
            {
                string scoreValidator = Console.ReadLine();
                byte score;      //User inputs score

                if (byte.TryParse(scoreValidator, out score))    //Input is checked for non-numeric elements
                {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    if (score > 0 && score < 4)     //Score is checked
                    {
                        Console.WriteLine("Your score+bonus score: " + score*10);
                    }
                    else if (score > 3 && score < 7)
                    {
                        Console.WriteLine("Your score+bonus score: " + score * 100);
                    }
                    else if (score > 6 && score < 10)
                    {
                        Console.WriteLine("Your score+bonus score: " + score * 1000);
                    }
                    else    //Case score is <1 or >9
                    {
                        Console.WriteLine("Invalid score");
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
                else
                {
                    Console.WriteLine("Parsing unsuccessful. Input is non-numeric");    //In case parsing is unsuccessful
                }
                Console.WriteLine("Wanna try again?");      //Program loops after this line
            }
        }
    }
}
