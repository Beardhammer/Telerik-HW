using System;
using System.Linq;

namespace _05_SortByLength
{
    /*Problem 5. Sort by string length

    You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
                                                                        */
    class SortByStringLength
    {
        static void Main()
        {
            Console.WriteLine("Please enter the elements for your array, separated by space, and I'll sort them by length for you!");
            while (true)
            {
                Console.WriteLine("Please enter the elements for your array, separated by space");
                string[] userArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);    //{ "Kiro", "Neprotivokonstitucistvuvatelstvuvam", "Pesho", "Talamat", "Bjor", "Chukundur Purvi", "A", "Johan Strauss" };
                userArray = userArray.OrderBy(x => x.Length).ToArray();     
                //Array.Sort(userArray,(x,y)=>x.Length.CompareTo(y.Length)); --> Found this on the interweb. Performs significantly faster because it just sorts the array instead of creating a new one. Can anyone explain exactly what "y" is and how it works? I can't quite get a grasp on this...
                Console.WriteLine("Hier ist your array:\n-->" + string.Join(", ", userArray) + "\n\nWanna try again?\n");
            }
        }
    }
}
