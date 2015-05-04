using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsolePrintMyName //Problem 5. Prints my name. Also prints any input names
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is Martin Ali");
            Console.WriteLine("What's yours?");
            String yourName;
            yourName = Console.ReadLine();                               //User enters his/her name here
            Console.WriteLine("Your name is " + yourName);
            Console.WriteLine("Press enter to close...");                //Keeps the program running. Do not delete
            Console.ReadLine();
        }
    }
}
