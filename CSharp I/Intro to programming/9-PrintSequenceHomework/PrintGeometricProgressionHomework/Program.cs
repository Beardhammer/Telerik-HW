using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintGeometricProgressionHomework //Problem 9.Prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ... 
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 2; i <= 11; i++)                   //Number starts at 2 and increases by one until it is <=11
            {
                if (i%2==0)                                 //Checks whether the number is odd or even
                {                
                Console.Write(i+", ");                      //Prints number
                }
                else 
                {
                    Console.WriteLine(-i);                  //Prints negative number
                }
            }
            Console.WriteLine("Press enter to close...");  //Keeps the program running. Do not delete.
            Console.ReadLine();
        }
    }
}
