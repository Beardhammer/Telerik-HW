using System;
using System.Text;

namespace _08_BinaryShort
{
    /*
     Problem 8. Binary short

    Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
                                                                                                                            */
    class BinaryShort
    {
        static void Main()
        {
            while (true)
            {
                Console.Write(
                    "Please enter a signed number(short) and I will show you its internal binary representation");
                string userInputVal = Console.ReadLine();
                short userInput = 0;

                if (short.TryParse(userInputVal, out userInput))
                {
                    Console.WriteLine("Your number: " + userInput + " has a binary presentation of\n--> " +
                                      NumberToByteArray(userInput));
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
            }
        }
        static string NumberToByteArray(short number)
        {
            byte[] numberBytes = BitConverter.GetBytes(number);
            StringBuilder inputToBinary = new StringBuilder();

            for (int i = 0; i < numberBytes.Length; i++)
            {
                inputToBinary.Insert(0,ConvertToBinary(numberBytes[i]).PadLeft(8, '0'));
            }
            return inputToBinary.ToString();
        }

        static string ConvertToBinary(byte numberByte)
        {
            string number = numberByte.ToString();
            StringBuilder decNumber=new StringBuilder();
            long y = Convert.ToInt32(number);
            for (int i = 0; y > 0; i++)
            {
                decNumber.Insert(0,(y % 2 == 0 ? '0' : '1'));
                y /= 2;
            }
            return decNumber.ToString();
        }
    }
}
