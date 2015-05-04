using System;

namespace _02_LargestNum
{
    /*Problem 2. Get largest number

    Write a method GetMax() with two parameters that returns the larger of two integers.
    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
                                                                                                                                */
    class MaxNum
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("What do you want me to do?\n" +
                              "array-->Gets max value from an array\n" +
                              "numbers-->Gets biggest from 3 numbers\n-->");

                string userAnswer = Console.ReadLine();
                if (userAnswer.ToLower() == "array")
                {
                    GetLargestFromArray();
                }
                else if (userAnswer.ToLower() == "numbers")
                {
                    GetLargestOf3();
                }
                else
                {
                    Console.WriteLine("\nError! Error! Wong ansa madafaka!\n(Your answer s incorrect. Please try again)\n");     //In case user inputs something invalid
                }


            }

        }

        private static void GetLargestFromArray()
        {
            Console.Write("Please enter your array on one line, separated by space\n-->");
            string[] userArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numberArray=new int[userArray.Length];
            int validator = 0;
            int index = 0;

            foreach (var item in userArray) //This whole block is just input validation
            {
                if (int.TryParse(item, out validator))
                {
                    numberArray[index++] = validator;
                    //index++;
                }
            }

            Array.Resize(ref numberArray,index);    //End input validation

            Console.WriteLine("Current array: " + string.Join(", ",numberArray));
            Console.WriteLine("The biggest number in your array is --> " + GetMaxFromArray(numberArray));
        }

        private static void GetLargestOf3()
        {
            while (true)
            {
                Console.Write("Please enter your first number\n-->");
                string firstNumVal = Console.ReadLine();
                Console.Write("Please enter your second number\n-->");
                string secondNumVal = Console.ReadLine();
                Console.Write("Please enter your third number\n-->");
                string thirdNumVal = Console.ReadLine();

                int firstNum = 0;
                int secondNum = 0;
                int thirdNum = 0;

                if (int.TryParse(firstNumVal, out firstNum) && int.TryParse(secondNumVal, out secondNum) &&
                    int.TryParse(thirdNumVal, out thirdNum))    //This is input validation
                {                    

                    Console.WriteLine("Your biggest number is --> " + GetMax(firstNum, secondNum, thirdNum));
                    break;
                }
                    Console.WriteLine("\n" + new string('-', 42) + "\nInvalid input detected! Please try again!\n" + new string('-', 42) + "\n"); //In case input validation fails
            }
        }

        static int GetMaxFromArray(int[] userArray)     //Non-optimised variant
        {
            int max = int.MinValue;         //"Self explanatory" code here :p If you read the forums, you'll know what I mean
            foreach (var number in userArray)
            {
                if (number > max)
                {
                    max = number;
                }
                //max = number > max ? number:max;  //At this point: Ternary-->Slower than if-else. It's slightly faster in other circumstances, though

            }

            //Array.Sort(userArray);        //This is also possible, but much slower
            //int max = userArray[userArray.Length - 1];
            return max;

        }
        static int GetMax(int firstNum, int secondNum, int thirdNum)   //Optimisation matters very little in such a short method, but it doesn't hurt
        {
            //int maxOfFirstOrSecond = firstNum > secondNum ? firstNum : secondNum; //Ternary version appears to be (slightly)slower than "if" for some reason. Need more testing 
            //Explanation: if firstNum > secondNum, then maxOfFirstOrSecond takes value of firstNum, otherwise it takes value of secondNum

            int maxOfFirstOrSecond = secondNum;
            if (firstNum > secondNum)
            {
                maxOfFirstOrSecond = firstNum;
            }

            if (maxOfFirstOrSecond > thirdNum)
            {
                return maxOfFirstOrSecond;
            }
                return thirdNum;    //Else

            //if (firstNum > secondNum)         //Technically works fastest, but is pointlessly more difficult to read for such a small performance difference
            //{
            //    if (firstNum > thirdNum)
            //    {
            //        return firstNum;
            //    }
            //    else
            //    {
            //        return thirdNum;
            //    }
            //}
            //else if (secondNum > firstNum)
            //{
            //    if (secondNum > thirdNum)
            //    {
            //        return secondNum;
            //    }
            //    else
            //    {
            //        return thirdNum;
            //    }
            //}
            //else
            //{
            //    if (thirdNum > secondNum)
            //    {
            //        return thirdNum;
            //    }
            //    else
            //    {
            //        return secondNum;
            //    }
            //}

        }
    }
}
