using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4  //Problem 7. Prints mine and input names on separate lines.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is \nMartin \nAli");                                        //Prints my name
            Console.WriteLine("What's your first name?");
            string yourFirstName=Console.ReadLine();                                               //User inputs first name here
            Console.WriteLine("What's your last name?");
            string yourLastName = Console.ReadLine();                                              //User Inputs last name here
            Console.WriteLine("Your names are \n" + yourFirstName + "\n" + yourLastName);          //Prints the names on separate lines
            Console.WriteLine("\nPress enter to close...");                                        //Keeps the program running. Do not delete
            Console.ReadLine();
        }
    }
}
