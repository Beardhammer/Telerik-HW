using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_PrimeNum1Mil
{
    class PrimeNumberPrinter
    {
        private static void Main()
        {
            int[] numberArray=new int[10000];
            bool[] areTheyPrime=new bool[numberArray.Length];
            for (int i = 2; i < numberArray.Length ; i++)
            {
                numberArray[i] = i;
            }
            Console.WriteLine(string.Join(", ", numberArray));

            //if num>2-->if num/2==0
        }

    }
}
