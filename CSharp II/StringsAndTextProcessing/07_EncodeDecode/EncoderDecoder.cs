using System;
using System.Collections.Generic;   //Leave this as it is
using System.Text;

namespace _07_EncodeDecode
{
    /*Problem 7. Encode/decode

    Write a program that encodes and decodes a string using given encryption key (cipher).
    The key consists of a sequence of characters.
    The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
                                                                                                    */
    class EncoderDecoderXOR
    {
        //Notes for those that have not had the chance to study booleran algebra yet: XOR or exclusive OR ("^" in C#) is 
        //an operation that compares items bit by bit and returns 0 if the bits at the same index are equal or 1 if they are not

        //Let me explain like this: 01011001 -->item2
        //                          01001111 -->item1
        //                          --------Result
        //We get                    00010110 -->item3
        //
        //And when we take          00010110 -->item3
        //                          01011001 -->item2
        //                          --------Result   
        //And now we're back to     01001111 -->item1

        //I believe it is also commonly reffered to as a "comparator" or something like that. If you XOR and item1 with item2 then we will call the result item3 
        //And when we XOR item3 with item2 for instance, we get item 1. This is how my encryption works. If you have difficulty with understanding logical gates, 
        //then I suggest you read up on them as they will likely become more important later on and they're not difficult to learn and understand anyway
        //Really, it takes 10 minutes to learn about the damn things!
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your key\n-->");
                string encryptionKey = Console.ReadLine();

                Console.Write("Please enter your text for encryption\n-->");
                string userInput = Console.ReadLine();
                StringBuilder encryptedData = new StringBuilder();
                //List was the initial build, but I switched to stringBuilder after some tests in which it was outperformed by stringBuilder
                //I'll leave the code just in case somebody's curious what the difference is. It's several rows underneath and commented out

                for (int i = 0, j = 0; i < userInput.Length; i++,j++)
                {
                    if (j >= encryptionKey.Length) j = 0;
                    encryptedData.Append(Convert.ToChar(userInput[i] ^ encryptionKey[j]));
                        //Encode by XOR-ing input with key
                }
                Console.WriteLine("\nYour info encrypted: " + encryptedData);

                for (int i = 0, j = 0; i < userInput.Length; i++,j++)
                {
                    if (j >= encryptionKey.Length) j = 0;
                    encryptedData[i] = Convert.ToChar(encryptedData[i] ^= encryptionKey[j]);
                        //Decode by XOR-ing encrypted items with key
                }
                Console.WriteLine("Your info decrypted: " + encryptedData);
            }

//--------------------------------DEAD--CODE--THAT--WAS--DEEMED--USELESS------------------------------------------------------------------------------------------------------
            //List<char> encryptedList = new List<char>();  

            //for (int i = 0, j = 0; i < userInput.Length; i++)
            //{
            //    if (j >= encryptionKey.Length) j = 0;
            //    encryptedList.Add(Convert.ToChar(userInput[i] ^ encryptionKey[j]));
            //    //Console.WriteLine("EncryptionKey[" + j + "] --> " + encryptionKey[j] + " char --> " + Convert.ToInt32(Convert.ToChar(encryptionKey[j])) + "\nUserInput[" + i + "] --> " +
            //    //userInput[i] + " char --> " + Convert.ToInt32(Convert.ToChar(userInput[i])));       //Used in debugging. I'm leaving in case you find it useful 
            //    j++;
            //}

            //Console.WriteLine("\nYour info encrypted: " + string.Join(",", encryptedList));

            //for (int i = 0, j = 0; i < userInput.Length; i++)
            //{
            //    if (j >= encryptionKey.Length) j = 0;
            //    encryptedData[i] = Convert.ToChar(encryptedData[i] ^= encryptionKey[j]);
            //    encryptedList[i] = Convert.ToChar(encryptedList[i] ^= encryptionKey[j]);
            //    //Console.WriteLine("EncryptionKey[" + j + "] --> " + encryptionKey[j] + " char --> " + Convert.ToInt32(Convert.ToChar(encryptionKey[j])) + "\nUserInput[" + i + "] --> " +
            //    //encryptedList[i] + " char --> " + Convert.ToInt32(Convert.ToChar(encryptedList[i])));
            //    j++;
            //}

            //Console.WriteLine("Your info decrypted: " + string.Join("", encryptedList));
        }
    }
}
