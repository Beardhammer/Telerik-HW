using System;

namespace _01_FillTheMatrix
{
    /*Problem 1. Fill the matrix

    Write a program that fills and prints a matrix of size (n, n) as shown below:
                                                                    */
    class FillTheMatrix
    {
        static void Main()  //Sorry, I didn't have the time to describe this program :(
        {
            while (true)
            {
                Console.Write("Please enter the size of your 2D array(Matrix):\n-->");
                string userInputValidator = Console.ReadLine(); 
                uint userInput = 0;

                if (uint.TryParse(userInputValidator, out userInput) && userInput>1)//int.TryParse(userInputValidator, out userInput))
                {
                    int[,] userNumArray = new int[userInput, userInput];
                    
                    while (true)
                    {
                        Console.WriteLine("Now choose the way it will be filled --> a/b/c\n-->");
                        string userAnswer = Console.ReadLine();

                        if (userAnswer == "a" || userAnswer == "A")
                        {
                            userNumArray = Variation_A(userNumArray);
                            break;
                        }
                        else if (userAnswer == "b" || userAnswer == "B")
                        {
                            userNumArray = Variation_B(userNumArray);
                            break;

                        }
                        else if (userAnswer == "c" || userAnswer == "C")
                        {
                            userNumArray = Variation_C(userNumArray);
                            break;
                        }
                        //else if (userAnswer == "d" || userAnswer == "D")
                        //{
                        //    userNumArray = Variation_D(userNumArray);
                        //    break;
                        //}
                        else
                        {
                            Console.WriteLine("Your input is utterly and completely......invalid. Please try again");
                        }
                    }

                    for (int j = 0; j < userNumArray.GetLength(1); j++)
                    {
                        Console.Write("->");
                        for (int i = 0; i < userNumArray.GetLength(0); i++)
                        {
                            Console.Write(userNumArray[i, j].ToString("00") + ",");     //Yes, yes, I know I fucked up the printing, but it's too late to change it now....haha! This really clears up a lot of strange issues!
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.Write("Size value invalid. Please try again");
                }
                Console.WriteLine("Want to try again?");
            }
        }

        private static int[,] Variation_A(int[,] userNumArray)
        {
            for (int row = 0, sizer = 1; row < userNumArray.GetLength(0); row++)
            {
                for (int col = 0; col < userNumArray.GetLength(1); col++, sizer++)
                {
                    userNumArray[row, col] = sizer;
                }
            }
            return userNumArray;
        }

        private static int[,] Variation_B(int[,] userNumArray)
        {

            byte sizer = 1;
            int x = 1;

            for (int row = 0; row < userNumArray.GetLength(0); row++)
            {
                if (x % 2 != 0)     //Trying to avoid too many ifs for a performance increase
                {
                    for (int col = 0; col < userNumArray.GetLength(1); col++)
                    {
                        userNumArray[row, col] = sizer;
                        sizer++;
                    }
                }
                else
                {
                    for (int col = userNumArray.GetLength(1) - 1; col >= 0; col--)
                    {
                        userNumArray[row, col] = sizer;
                        sizer++;
                    }
                }
                x++;
            }
            return userNumArray;
        }

        private static int[,] Variation_C(int[,] userNumArray)  //This one was...just...awful. So damn...
        {
            int sizer = 1;
            for (int row = (userNumArray.GetLength(0) - 1); row >= 0; row--)
            {
                int tempRow = row;
                for (int col = 0; col < (userNumArray.GetLength(0) - row); col++)
                {
                    userNumArray[col, tempRow] = sizer;
                    sizer++;
                    tempRow++;
                }
            }

            sizer = userNumArray.GetLength(0) * userNumArray.GetLength(0);

            for (int row = 0; row < (userNumArray.GetLength(0) - 1); row++)
            {
                int tempRow = row;
                for (int col = (userNumArray.GetLength(0) - 1); tempRow >= 0; col--)
                {
                    userNumArray[col, tempRow] = sizer;
                    sizer--;
                    tempRow--;
                }
            }
            return userNumArray;
        }

        private static int[,] Variation_D(int[,] userNumArray)
        {
            return userNumArray;
            //Didn't have time for this :(
        }
    }
}
