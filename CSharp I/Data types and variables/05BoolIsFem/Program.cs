using System;

namespace _05BoolIsFem //05-Assigns a bool named isFemale a value and asks about user gender. Not much to look at, eh?
{
    /*  Problem 5. Boolean Variable

    Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
    Print it on the console.    */

    class Program
    {
        static void Main(string[] args)
        {
            bool isFemale = false;      
            Console.WriteLine("Am I, Martin, a woman?-" + isFemale + "\nOk. Now that we've stablished that, apparently, I'm not a woman. Let's ask you!\nWhat's your gender?-->m/f");   //Not much to describe here
            for (int i=1; i <= 50000; i++)  //Loop keeps the program running
            {
            
            string yourGender= Console.ReadLine();  //User inputs gender here. Only m(Male) and f(Female) format allowed
//-----------------------------------------------Case--Male-------------------------------------------------------------------------------------------------------------------
            if (yourGender=="m")    //Case user input is "m"
            {
                Console.WriteLine("Congratulations! You're a man!");
            }
//-----------------------------------------------Case--Female-------------------------------------------------------------------------------------------------------------------
            else if (yourGender=="f")   
            {
                Console.WriteLine("Congratulations! You're a woman!");
            }
//-----------------------------------------------Case--Invalid--Input-------------------------------------------------------------------------------------------------------------------
            else
            {
                Console.WriteLine("Congratulations! You are....uhhhh....ummmm......human.....I think....."); 
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.BackgroundColor = ConsoleColor.Red;     //Sets BackColor to red specifically for this line. Need to find more efficient way to do it
                Console.WriteLine("\nStill unsure about you gender? Then try again!");
                Console.ResetColor();   //Resets BackColor so it doesn't stay red every loop
            }
        }
    }
}
