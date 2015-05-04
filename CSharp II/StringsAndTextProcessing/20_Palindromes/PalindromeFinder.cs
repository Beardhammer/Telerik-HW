using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20_Palindromes
{
    /*Problem 20. Palindromes

    Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
                                                                                                        */
    class PalindromeFinder  //Unfortunately, this is gonna have to be the last one. I simply don't have the time to finish the assignment :(
    {
        static void Main()  //Sorry this is hard-coded. I just ran out of time to write something better :(
        {
            string palindromes = "lamal abba hello, mate, how are you doing? Are you labal my tamat or any cat with a mat?";
            List<string> x = palindromes.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

            StringBuilder palindromeContainer=new StringBuilder();
            bool check = true;
            foreach (var item in x)
            {
                for (int i = 0; i < item.Length/2; i++)
                {
                    if (item[i] != item[item.Length - i - 1])   //Basically if non-equal elements are found break and do not append item to palindromeContainer
                    {
                        check = false;
                        i = item.Length;
                    }
                }
                if (check && item.Length>1) palindromeContainer.Append(item+", ");
                check = true;
            }
            Console.WriteLine(palindromeContainer);
        }
    }
}
