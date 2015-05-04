using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersTelerikHomework //Prints the numbers 1, 101, and 1001 on separate lines.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1 + "\n" + 101 + "\n" + 1001);
            Console.WriteLine("Press enter to close...");              //Keeps the program running. Do not delete
            Console.ReadLine();
        }
    }
}
