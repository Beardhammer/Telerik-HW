using System;

namespace _02_RandomNumbers
{
    /*
     Problem 2. Random numbers

    Write a program that generates and prints to the console 10 random values in the range [100, 200].
                                                                                                            */
    class RandomNums
    {
        static Random _rngSeed=new Random();
        static void Main()
        {
            while (true)
            {
                Console.Write("How many random numbers shall I generate?\n-->");
                string randNumCountValidator = Console.ReadLine();

                Console.Write("What shall be the min range for them?\n-->");
                string randNumMinValidator = Console.ReadLine();

                Console.Write("What shall be the max range?\n-->");
                string randNumMaxValidator = Console.ReadLine();

                int randNumCount = 0;
                int randNumMin = 0;
                int randNumMax = 0;

                if (int.TryParse(randNumCountValidator, out randNumCount) && //Input validation
                    int.TryParse(randNumMaxValidator, out randNumMax) &&
                    int.TryParse(randNumMinValidator, out randNumMin))
                {
                    for (int i = 0; i < randNumCount; i++) //Random numbers are generated right before printing
                    {
                        Console.WriteLine("number " + i + " --> " + _rngSeed.Next(randNumMin, randNumMax));
                            //Not random enough. Use Guid.NewGuid().GetHashCode() ??
                    }
                }
            }
        }
    }
}
