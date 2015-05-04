using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_PrintLongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1001; i++)                                //Number starts at 1 and increases by 1 until it is <=1001
            {
               if (i % 2 == 0)                                             //Checks whether the number is odd or even
               { 
                   
                    Console.Write(i + ", ");                               //Prints number
                    
               }
               else
               {
                   Console.WriteLine(-i);
                   Console.ReadLine();                           //Advances only on user input. It's a safety precaution to make sure there are no skipped numbers
                    
               }
            }
            Console.WriteLine("Press enter to close...");                  //Keeps the program running. Do not delete.
            Console.ReadLine();
        }
    }
}
