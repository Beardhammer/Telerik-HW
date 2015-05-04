using System;

namespace _14_IntCalculations
{
    /*Problem 14. Integer calculations

    Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
    Use variable number of arguments.
                                                    */
    class IntegerCalculation
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your set on a single line, separated by space\n-->");
                string[] numberArrayValidator = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                int[] numberArray = new int[numberArrayValidator.Length]; //Whole block is array input validation
                //{1,43,43,4,4,5,27,27,78,887,342,442,454,47,907};

                int validator;
                int indexer = 0;
                foreach (var item in numberArrayValidator)
                {
                    if (int.TryParse(item, out validator))
                    {
                        numberArray[indexer] = validator;
                        indexer++;
                    }
                }
                Array.Resize(ref numberArray, indexer); //End input validation

                Console.WriteLine("Your current set: " + String.Join(", ", numberArray) + "\n");    //Showing user cleaned array

                SetAverage(numberArray);    //You can call them with an array, or you can give them as many arguments as you like
                SetMaximum(numberArray);
                SetMinimum(numberArray);
                SetProduct(numberArray);
                SetSum(numberArray);
            }
        }

        static void SetMaximum(params int[] numberArray)   //Loops through array in search of biggest number
        {
            int max = numberArray[0];
            foreach (var item in numberArray)
            {
                if (item > max) max = item;
            }
            Console.WriteLine("Max: " + max);
        }

        static void SetMinimum(params int[] numberArray)   //Loops through array in search of smallest number
        {
            int min = numberArray[0];
            foreach (var item in numberArray)
            {
                if (item < min) min = item;
            }
            Console.WriteLine("Min: " + min);
        }
        static void SetSum(params int[] numberArray)   //Loops through array, adding every item to sum variable
        {
            int sum = 0;
            foreach (var item in numberArray)
            {
                sum += item;
            }
            Console.WriteLine("Sum: " + sum);
        }
        static void SetAverage(params int[] numberArray)   //Sums all numbers, then divides by their count
        {
            int average = 0;
            foreach (var item in numberArray)
            {
                average += item;
            }
            Console.WriteLine("Average: " + average/numberArray.Length);
        }
        static void SetProduct(params int[] numberArray)   //Multiplies all numbers to product
        {
            long product = 1;       //No need for BigInteger
            foreach (var item in numberArray)
            {
                product *= item;
            }
            Console.WriteLine("Product: " + product);
        }
    }
}
