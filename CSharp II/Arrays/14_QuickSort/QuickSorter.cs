using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_QuickSort
{
    //And this, friend, is where I'm afraid our journey must end, for after 10 long days of struggle with the C#, the hero finally succumbed to the darkness. 
    //This, however is all but the end. A struggle, difficulty only serves to strengthen the already strong and to break the weak, and out hero was all but weak. 
    //For I, no, We are sure of it. One day. Maybe not today, but one day, he will be back, just as the prophecies have foretold, just as all those before him, and just as those that follow, and in his hands shall he carry the sacred treasure, the gift of programming.
    //And with the gift, he shall smite the C#, and banish it to whence it came, and create a golden age for all programmers. 
    //You, however, should be patient, good friend, for all good things come in due time, and those who that travel the slowest, they get the farthest

    class QuickSorter   
    {
        static void Main()
        {/*
            Console.WriteLine("Please enter the numbers that will be sorted on a single line, sparated by space");
            string[] userInputArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //User input

            int[] numberArray = new int[userInputArray.Length];
            int index = 0;
            int validator = 0;
            for (int i = 0; i < userInputArray.Length; i++)     //Input validation
            {
                if (int.TryParse(userInputArray[i], out validator)) //All numeric values are cloned into numberArray, while non-numeric ones are ignored
                {
                    numberArray[index] = validator;
                    index++;
                }
            }
            Array.Resize(ref numberArray, index);    //Size of numberArray is cut to only have numeric values*/
            int[] numberArray = { 10, 60, 70, 40, 80, 90, 20, 30, 50, 100 };

            numberArray = QuickSort(numberArray);     
            Console.WriteLine(string.Join(", ", numberArray));  //Displaying results
        }

        private static int[] QuickSort(int[] numberArray)
        {
           
        }
    }
}
