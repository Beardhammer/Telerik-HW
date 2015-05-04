using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQRootCalculatorHomework //Calculates square root of input numbers and 12345 in particular.
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqRootOf12345 = Math.Sqrt(12345);                                       //Calculates square root of 12345 and saves it in a varable of type double
            Console.WriteLine("Square root of 12345 is: {0}", sqRootOf12345);              //Prints result of the calculation above
            Console.WriteLine("Do you want to calculate another square root?y/n");         
            string answerToYesNoClose = Console.ReadLine();           
            if (answerToYesNoClose.Equals("y"))                                            //Used for the sole purpose of the question above
            {
                
                Console.WriteLine("Enter a number");                                        
                int sqRootInputNumber = Convert.ToInt32(Console.ReadLine());               //Number input by user
                double sqRootResultNumber = Math.Sqrt(sqRootInputNumber);                  //Calculates root of the number
                Console.WriteLine("The square root of your number is: " + sqRootResultNumber);    //Prints root
                Console.WriteLine("Press enter to close...");                                     //Keeps the program running. Do not delete
                Console.ReadLine();
            }                                                                              //End of first "If"
            else 
            {
            }
                      
        }
    }
}
