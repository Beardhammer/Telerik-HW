using System;

namespace _10_EmpData   //10-A marketing company wants to keep record of its employees. Each record would have certain characteristics: First name, Last name, Gender, Personal ID number, and Unique Employee Number
{
    /*  Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.    */

    class Program
    {
        static void Main(string[] args)
        {
            string firstName="Martin";
            string lastName="Ali";
            byte age=19;
            //bool genderIsMale=true ;       //I'll probably use this
            string gender="Male";            //Alternative. In case I don't - And apparently I didn't...
            long PersonalID=8306112507;
            long UniqueEmpNumber=27568585;
            Console.WriteLine("Welcome to out company, I am " + firstName + " " + lastName + ", I am a " + age + " years old " + gender + "\nMy Personal ID is: " + PersonalID + " and my Unique employee number is: " + UniqueEmpNumber + "\nI will be you boss from today on. any questions?");   //Prints my personal imaginary info
            Console.WriteLine("\nAre you completely sure you want to work at our firm?\nPlease use only \"yes\" or \"no\" as answers\nOn a \"no\", this program will automatically close itself");   //User inputs "yes" or "no" here. On a "no" input the program shuts down. Loop repeats until either "yes" or "no" is input
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 1; i <= 50000; i++)    ////Loop helps with incorrect input. If input is invalid, it makes user try again
            {
                string answer=Console.ReadLine();
                if (answer == "yes")    //Software reads next lines of code only on answer="yes"
                {
                        Console.WriteLine("Great. Please enter your first name then");

                        string userFirstName = Console.ReadLine();  //Not much can go wrong with strings, so I didn't put any input validation here

                        Console.WriteLine("And what is your last name?");

                        string userLastName = Console.ReadLine();

                        Console.WriteLine("Welcome to our company, " + userFirstName + " " + userLastName);

                        Console.WriteLine("\nPlease input your age now(in 0-255 format)");

                        for (int jessus = 1; jessus <= 50000; jessus++)    //Loop helps with incorrect input. If input is invalid, it makes you try again
                        {
                            byte userAgeByte;   //If string value is a valid number, this byte save user age
                            string userAge = Console.ReadLine();    //String is used for input validation
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            if (byte.TryParse(userAge, out userAgeByte))    //Input validation. No need to modify further
                            {
                                if (userAgeByte < 18)   //If user age is <18, exits program
                                {
                                    Console.WriteLine("Aren't you a little young to be working in a software development company?\nYou will not be registered");
                                    System.Environment.Exit(1);
                                }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                else
                                {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                    Console.WriteLine("Please input you gender now in m, if male or f, if female format");
                                    for (int crazyManyLoops = 1; crazyManyLoops <= 50000; crazyManyLoops++)    //Loop helps with incorrect input. If input is invalid, it makes you try again
                                    {
                                        string userGender = Console.ReadLine();            //Reads user gender, though only checks for "m" or "f"

                                        Random userUniqueEmpNumRand = new Random();    //Randomly generated user Unique Employee Number
                                        string userUniqueEmpNum = userUniqueEmpNumRand.Next(27560000, 27569999).ToString();

                                        Random userPersonalIDRand = new Random();      //Randomly generated Personal ID Number
                                        string userPersonalID = userPersonalIDRand.Next(100000000, 999999999).ToString();
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                        if (userGender == "m")  //Case user is male
                                        {
                                            Console.WriteLine("Congratulations on being accepted to our company, sir.\nHere are your final details: \nName: " + userFirstName + " " + userLastName + "\nAge: You are " + userAgeByte + " years old\nGender/Sex : Male\nPersonal ID Number(PID): " + userPersonalID + "\nUnique Employee Number(UEN): " + userUniqueEmpNum + "\nHave a nice time in our company from now on :)");
                                        }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                        else if (userGender == "f")    //Case user is female
                                        {                                           
                                            Console.WriteLine("Congratulations on being accepted to our company, miss.\nHere are your final details: \nName: " + userFirstName + " " + userLastName + "\nAge: You are " + userAgeByte + " years old\nGender/Sex : Female\nPersonal ID Number(PID): " + userPersonalID + "\nUnique Employee Number(UEN): " + userUniqueEmpNum + "\nHave a nice time in our company from now on :)");
                                        }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                        else
                                        {
                                            Console.WriteLine("Trying to be a smartass, eh? WRONG. Try again, please");    //In case input is not m/f, makes user try again
                                        }
                                    }
                                }
                            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            else
                            {
                                Console.WriteLine(userAge + " is NOT an age, mate. Please try again and for real this time");   //In case age validation fails, makes user try again
                            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        }
                }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else if (answer == "no")
                {
                    System.Environment.Exit(1);    //Closes software on answer "no"
                }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else
                {
                    Console.WriteLine("Invalid input detected. Please try again");  //Appears if input was not "yes" or "no". Loop repeats until either "yes" or "no" is input
                }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
            }
        }
    }
}
