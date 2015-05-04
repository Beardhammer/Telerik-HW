using System;

namespace _07_Sort
{
    /*Problem 7. Selection sort

    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
                                                                */
    class SelectionSort     //Note: At this point, my computer idiotically decided it's time to reboot. By force. Visual studio went nuts on next startup and I'd lost some data. I tested all programs, repaired a little missing code, but I am no machine. I don't know all the code by heart, so there may be missing elements in any programs before 08 :(
    {
        static void Main()  //Two implementations of selection sort used here
        {
            Console.WriteLine("I give you exactly TWO choices\n");
            while (true)
            {
                Console.Write("1-->You get a randomly generated array of user-defined size, (probably)full of unsorted numbers. \n" +
                                  "It will be sorted automatically. Lazy mortals.\n"  +
                                  "2-->YOU input the numbers, gain my favor and then see them get sorted like a man!\n" +
                                  "Make your choice, mortal....\n" +
                                  "Note: version 1 uses my personal implementation of selection sort, while version 2 uses the most common one\n-->");

                string userChoice = Console.ReadLine();
                if (userChoice == "1")  
                {
                    LazyAssVersion();
                }
                else if (userChoice == "2")
                {
                    while (true)
                    {
                        ManlyVersion();
                    }
                }
                else    //Case user inputs bullshit
                {
                    Console.WriteLine("I told you 1 OR 2. Don't play with my patience, mortal!\n" +
                                      "Here're the instructions again:\n");

                }
            }
        }

        private static void ManlyVersion()
        {
            Console.WriteLine("Enter your numbers on a single line, separated by space");
            string[] userInputArray =Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//
            /*{
                "g", "a", "5", "-1", "0", "g", "g", "3", "4", "5", "h", "g", "f","hg", "f", "4", "6", "g", "g",
                "f", "4", "6", "6", "g", "g", "4", "8", "6", "g", "q", "r", "6", "9", "g", "a", "5", "-1", "0", "g", "g",
                "3", "4", "5", "g", "f", "f", "4", "6", "g", "g", "f", "4", "6", "6", "g", "g", "4", "8", "6", "g", "q",
                "r",
                "6", "9", "n"
            };*///Need some input? Here you go!

            var stepCountforSort = 0;
            int variousValidator = 0;
            int validItemsCounter = 0;

            int[] numberArray = new int[userInputArray.Length]; //Creating new numeric array
            int indexForNumbers = 0;

            for (int i = 0; i < userInputArray.Length; i++)     //Old array is getting scanned
            {
                if (int.TryParse(userInputArray[i], out variousValidator))  //Every number is passed to the new array and counter for the index is increased
                {
                    numberArray[indexForNumbers] = variousValidator;
                    indexForNumbers++;                      //Counter for index. If I use "i" instead, there will be jumps on every index with a non-numeric value
                    validItemsCounter++;                    //Used for cutting off useless non-numeric items off aray.
                }
            }

            Array.Resize(ref numberArray, validItemsCounter);      //Array gets resized according to instructing number

            for (int i = 0; i < numberArray.Length - 1; i++)        //Selection sort. Problem?
            {
                for (int e = i + 1; e < numberArray.Length; e++)
                {
                    if (numberArray[i] > numberArray[e])
                    {
                        stepCountforSort++;
                        int tmp = numberArray[i];
                        numberArray[i] = numberArray[e];
                        numberArray[e] = tmp;
                    }
                }
            }
            Console.WriteLine("Number of steps used....Roughly: " + stepCountforSort);  //I have no idea what this number is. I just named it stepCounter and the name stuck....Who know, maybe one day it will turn out to actually be counting steps!
            Console.WriteLine(string.Join(", ", numberArray));      //Prints newly sorted array
        }

        private static void LazyAssVersion()
        {
            var stepCountSort = 0;
            var rngSeed = new Random();    //Rnd is random enough. No need to use "new Random(Guid.NewGuid().GetHashCode())" instead

            int[] numberArray = new int[50];    //Nope. User defined would mean input, but inputting is hard. No input. The same goes for the rest of the code

            for (int das = 0; das < 50; das++)  //Array gets populated with seed of RNGseed....
            {
                int rndInt = rngSeed.Next(0, 200);
                numberArray[das] = rndInt;
            }

            Console.WriteLine("Initial order: " + string.Join(", ", numberArray) + "\n");

            int currentMinNum = int.MaxValue;
            int currentMaxNum = 0;
            int smallestRecordedNum = int.MaxValue;
            int maxRecordedNum = 0;
            int indexOfeExchange= 0;

            for (int i = 0; i < numberArray.Length; i++)    //This is my attempt at a personal implementation of selection sort. It's roughly 50% slower and more difficult to read, but I like it 'cause it's mine. Most common implementation is used in other block(ManlyVersion)
            {
                for (int e = i+1; e < numberArray.Length; e++)
                {
                    currentMinNum = Math.Min(numberArray[i], numberArray[e]);   //Gets smallest of the two currently compared numbers at [i] and [e]
                    currentMaxNum = Math.Max(numberArray[i], numberArray[e]);   //Gets smallest of the two currently compared numbers at [i] and [e]
                    if (currentMinNum < smallestRecordedNum)                    //If current number is smaller than smallest recored, then:
                    {
                        stepCountSort++;                            //Step counter increases
                        smallestRecordedNum = currentMinNum;        //Smallest number recorded becomes current number
                        maxRecordedNum = currentMaxNum;             //Other number is also recorded
                        indexOfeExchange = e;                       //Index of other number is also recorded
                    }
                }
                numberArray[i] = smallestRecordedNum;       //Values are swapped
                numberArray[indexOfeExchange] = maxRecordedNum;
                smallestRecordedNum = int.MaxValue;         //Smallest recorded number is reset
            }

            Console.WriteLine("Number of steps used....I think: " + stepCountSort);
            Console.WriteLine("Sorted: " + string.Join(", ", numberArray) + "\n\nDo you want to try again, human?\n");
        }
    }
}
