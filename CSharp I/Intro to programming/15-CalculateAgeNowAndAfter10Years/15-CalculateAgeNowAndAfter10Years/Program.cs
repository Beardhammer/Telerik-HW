using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_CalculateAgeNowAndAfter10Years //Reads birthday from the console and prints how old you are now and how old you will be after 10 years.
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime CurrentDateTime = DateTime.Now;                                   //Varable CurrentDateTime takes value of current date and time
            Console.WriteLine("Current date is: " + CurrentDateTime.Date);             //Prints value of CurrentDateTime variable

            Console.WriteLine("When were you born?");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());                //Gets input from console and converts it to DateTme type
            int age = DateTime.Now.Year - birthday.Year;                               //Calculates your age by taking current date into account
            Console.WriteLine("Your birthday was in " + birthday + ", right?");        //Prints user input
            Console.WriteLine("That means you're roughly " + age);                     //Prints calculated user age
            Console.WriteLine("After 10 years it will be: " + birthday.AddYears(10));  //Calculates what year it will be in 10 years
            Console.WriteLine("And you will be roughly " + (age+10) + " years old");   //Calculates how old user will be in 10 years
            Console.WriteLine("Press enter to close...");                                           //Keeps the program running. Do not delete.                                                   
            Console.ReadLine();
        }
    }
}
