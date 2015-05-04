using System;
using System.Linq;
using System.Text;

namespace _01_06_BinDecHexConvert
{
    /*Problem 1. Decimal to binary

    Write a program to convert decimal numbers to their binary representation.

Problem 2. Binary to decimal

    Write a program to convert binary numbers to their decimal representation.

Problem 3. Decimal to hexadecimal

    Write a program to convert decimal numbers to their hexadecimal representation.

Problem 4. Hexadecimal to decimal

    Write a program to convert hexadecimal numbers to their decimal representation.

Problem 5. Hexadecimal to binary

    Write a program to convert hexadecimal numbers to binary numbers (directly).

Problem 6. Binary to hexadecimal

    Write a program to convert binary numbers to hexadecimal numbers (directly).

Problem 7. One system to any other

    Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
                                                                                                                                                */
    class DinDecHexConverter
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your number and I will convert it to hex, binary, and decimal\n-->");
                string number = Console.ReadLine();
                Console.WriteLine();
                ConvertToBin(number);
                ConvertToDec(number);
                ConvertToHex(number);
                Console.WriteLine();
            }
        }

        static void ConvertToHex(string number)
        {
      
            if (!number.Except("01").Any())
            {
                number=number.PadLeft(16, '0');
                string mm = string.Empty;
                StringBuilder nn=new StringBuilder();
                for (int i = 4; number.Length-(i)>=0; i+=4)
                {
                    mm=number.Substring(i-4, 4);
                    switch (mm)
                    {
                        case "1111":
                           mm = "F";
                            break;
                        case "1110":
                            mm = "E";
                            break;
                        case "1101":
                            mm = "D";
                            break;
                        case "1100":
                            mm = "C";
                            break;
                        case "1011":
                            mm = "B";
                            break;
                        case "1010":
                            mm = "A";
                            break;
                        case "1001":
                            mm = "9";
                            break;
                        case "1000":
                            mm = "8";
                            break;
                        case "0111":
                            mm = "7";
                            break;
                        case "0110":
                            mm = "6";
                            break;
                        case "0101":
                            mm = "5";
                            break;
                        case "0100":
                            mm = "4";
                            break;
                        case "0011":
                            mm = "3";
                            break;
                        case "0010":
                            mm = "2";
                            break;
                        case "0001":
                            mm = "1";
                            break;
                        case "0000":
                            mm = "0";
                            break;
                    }
                    if (nn.Length > 0 || mm != "0")
                    {
                        nn.Append(mm);
                    }
                }
                Console.WriteLine("Your number in hexadecimal format --> " + nn);
            }
            else if (!number.Except("0123456789").Any())
            {
                string x = string.Empty;
                int y = int.Parse(number);
                StringBuilder z=new StringBuilder();
                for (int i = 0; y>0 ; i++)
                {
                    x = (y%16).ToString();
                    if (!x.Except("0123456789").Any())
                    {
                        switch (x.ToUpper())
                        {
                            case "10":
                                x = "A";
                                break;
                            case "11":
                                x = "B";
                                break;
                            case "12":
                                x = "C";
                                break;
                            case "13":
                                x = "D";
                                break;
                            case "14":
                                x = "E";
                                break;
                            case "15":
                                x = "F";
                                break;
                        }
                    }
                    z=z.Insert(0, x);
                    y /= 16;
                }
                Console.WriteLine("Your number in hexadecimal format --> " + z);
            }
            else if (!number.Except("0123456789ABCDEFabcdef").Any())
            {
                Console.WriteLine("Your number is already hexadecimal and doesn't need conversion");
            }
            else
            {
                Console.WriteLine("Number is not convertible to hexadecimal");
            }
        }
        static void ConvertToBin(string number)
        {
            if (!number.Except("01").Any())
            {
                Console.WriteLine("Your number is already in binary and doesn't need conversion");
            }
            else if (!number.Except("0123456789").Any())
            {
                char[] decNumber = new char[] { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' };
                long y = Convert.ToInt32(number);
                for (int i = 0; y > 0; i++)
                {
                    decNumber[decNumber.Length - (i + 1)] = (y % 2 == 0 ? '0' : '1');
                    y /= 2;
                }
                Console.WriteLine("Your number in binary format --> " + string.Join("", decNumber));

            }
            else if (!number.Except("0123456789ABCDEFabcdef").Any())
            {
                string[] decNumber = { "0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000" };
                string y = string.Empty;
                for (int i = 0; i < number.Length; i++)
                {
                    switch (number.Substring(number.Length - (i + 1), 1).ToUpper())
                    {
                        case "F":
                            y = "1111";
                            break;
                        case "E":
                            y = "1110";
                            break;
                        case "D":
                            y = "1101";
                            break;
                        case "C":
                            y = "1100";
                            break;
                        case "B":
                            y = "1011";
                            break;
                        case "A":
                            y = "1010";
                            break;
                        case "9":
                            y = "1001";
                            break;
                        case "8":
                            y = "1000";
                            break;
                        case "7":
                            y = "0111";
                            break;
                        case "6":
                            y = "0110";
                            break;
                        case "5":
                            y = "0101";
                            break;
                        case "4":
                            y = "0100";
                            break;
                        case "3":
                            y = "0011";
                            break;
                        case "2":
                            y = "0010";
                            break;
                        case "1":
                            y = "0001";
                            break;
                        case "0":
                            y = "0000";
                            break;
                    }

                    decNumber[decNumber.Length - (i + 1)] = y;
                }
                Console.WriteLine("Your number in binary format --> " + string.Join(" ", decNumber));

            }
            else
            {
                Console.WriteLine("Number is not convertible to binary");

            }
        }
        static void ConvertToDec(string number)
        {
            if (!number.Except("01").Any())
            {
                long decNumber = 0;
                byte y = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    y = Convert.ToByte(number.Substring(number.Length - (i + 1), 1));

                    decNumber += (Convert.ToInt64(y) * (Convert.ToInt64(Math.Pow(2, i))));
                }
                Console.WriteLine("Your number in decimal format --> " + decNumber);

            }
            else if (!number.Except("0123456789").Any())
            {
                Console.WriteLine("Your number is already in decimal and doesn't need conversion");
            }
            else if (!number.Except("0123456789ABCDEFabcdef").Any())
            {
                //Console.WriteLine("Your number is hexadecimal");
                long decNumber = 0;
                byte y = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    if (!number.Substring(number.Length - (i + 1), 1).Except("ABCDEFabcdef").Any())
                    {
                        string xx = number.Substring(number.Length - (i + 1), 1);
                        switch (xx.ToUpper())
                        {
                            case "A":
                                y = 10;
                                break;
                            case "B":
                                y = 11;
                                break;
                            case "C":
                                y = 12;
                                break;
                            case "D":
                                y = 13;
                                break;
                            case "E":
                                y = 14;
                                break;
                            case "F":
                                y = 15;
                                break;
                        }
                    }
                    else
                    {
                        y = Convert.ToByte(number.Substring(number.Length - (i + 1), 1));
                    }
                    decNumber += (Convert.ToInt64(y) * (Convert.ToInt64(Math.Pow(16, i))));
                }
                Console.WriteLine("Your number in decimal format --> " + decNumber);

            }
            else
            {
                Console.WriteLine("Number is not convertible to decimal");
            }
        }
    }
}
