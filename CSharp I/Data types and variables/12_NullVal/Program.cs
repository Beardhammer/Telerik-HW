using System;

namespace _12_NullVal
{
    /*  Problem 12. Null Values Arithmetic

    Create a program that assigns null values to an integer and to a double variable.
    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result. */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Nothing to look at, mate. Just a lil' console program her";
            int? nullInt=null;    //Null int. Problem?
            double? nullDouble=null;    //Null double. Problem?
            Console.WriteLine("Null integer value: "+nullInt + "\nAnd null double value: " + nullDouble );  //Prints values of nullInt and nullDouble. Hint: They're null :p

            Console.WriteLine("\nHey!Pssst!Here. You want to do something cool with those borin' ol' null values?\nClicky anything then...huehuehue");  
            Console.ReadKey();    //Pressing a key causes program to continue
            nullInt = (nullInt + 2 + null);
            nullDouble = (nullDouble + 3.0);
            Console.WriteLine("\nNow after some highly elaborate mostly mathematical calculations,\nhere are their new values!\n\nNull integer value: " + nullInt + "\nAnd null double value: " + nullDouble + "\nWhat?!They're still null??FUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU");
            Console.Title = "FUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU";
            Console.ReadLine();
            
        }
    }
}
