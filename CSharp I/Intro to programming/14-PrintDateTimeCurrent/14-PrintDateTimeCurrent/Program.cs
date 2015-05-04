using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PrintDateTimeCurrent //Problem 14. Prints current date and time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime CurrentDateTime = DateTime.Now;         //Varable CurrentDateTime takes value of current date and time
            Console.WriteLine(CurrentDateTime );             //Prints value of CurrentDateTime variable
            Console.WriteLine("Press enter to close...");    //Keeps the program running. Do not delete.
            Console.ReadLine();
        }
    }
}
