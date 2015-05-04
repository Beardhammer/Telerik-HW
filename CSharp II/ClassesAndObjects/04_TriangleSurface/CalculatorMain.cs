using System;

namespace _04_TriangleSurface
{
    /*
     Problem 4. Triangle surface

    Write methods that calculate the surface of a triangle by given:
        Side and an altitude to it;
        Three sides;
        Two sides and an angle between them;
    Use System.Math.
                                */
    class CalculatorMain
    {
        private static void Main()
        {
            while (true)
            {
                Triangle meinTriangle = new Triangle();     //Class triangle contains formulas for the calculations. Don't be bothered by it, it's just me trying to make a working class :)
                Console.Write("How shall I calculate the Area of your triangle?\n1-->By height and base\n2-->By three sides\n3-->By two sides and an angle\n-->");
                string action = Console.ReadLine();

                if (action == "1")
                {
                    CalculateAreaByHeightAndBase(meinTriangle);
                }
                else if (action == "2")
                {
                    CalculateAreaByThreeSides(meinTriangle);
                }
                else if (action == "3")
                {
                    CalculateAreaByAngleAndTwoSides(meinTriangle);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
            }
        }

        static void CalculateAreaByHeightAndBase(Triangle meinTriangle)     //Use "calculate" instead of "get" to avoid confusion with methods in triangle class
        {
            Console.Write("Please enter triangle height\n-->");
            string heightVal = Console.ReadLine();

            Console.Write("Please enter triangle base\n-->");
            string baseVal = Console.ReadLine();

            int height = 0;
            int triangleBase = 0;

            if (int.TryParse(heightVal, out height) && int.TryParse(baseVal, out triangleBase))     //Input validation
            {
                Console.WriteLine("The area of your triangle is ({0}/2)*{1} = {2}\n", triangleBase, height,
                    meinTriangle.GetAreaHeightAndBase(height, triangleBase));
            }
            else
            {
                Console.WriteLine("Invalid height or base. Please check your input and try again");
            }
        }
        static void CalculateAreaByThreeSides(Triangle meinTriangle)
        {
            Console.Write("Please enter triangle side a\n-->");
            string firstSideVal = Console.ReadLine();

            Console.Write("Please enter triangle side b\n-->");
            string secondSideVal = Console.ReadLine();

            Console.Write("Please enter triangle side x\n-->");
            string thirdSideVal = Console.ReadLine();

            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 0;

            if (int.TryParse(firstSideVal, out firstSide) && int.TryParse(secondSideVal, out secondSide) && int.TryParse(thirdSideVal, out thirdSide))     //Input validation
            {
                Console.WriteLine("The area of your triangle is Math.Sqrt({4} * ({4} - {0}) * ({4} - {1}) * ({4} - {2})) = {3}\n", firstSide, secondSide, thirdSide,
                    meinTriangle.GetAreaThreeSides(firstSide, secondSide, thirdSide), (firstSide + secondSide + thirdSide) / 2);
            }
            else
            {
                Console.WriteLine("Invalid side. Please check your input and try again");
            }
        }

        static void CalculateAreaByAngleAndTwoSides(Triangle meinTriangle)
        {
            Console.Write("Please enter triangle side a\n-->");
            string firstSideVal = Console.ReadLine();

            Console.Write("Please enter triangle side b\n-->");
            string secondSideVal = Console.ReadLine();

            Console.Write("Please enter triangle angle\n-->");
            string angleVal = Console.ReadLine();

            int firstSide = 0;
            int secondSide = 0;
            int angle = 0;

            if (int.TryParse(firstSideVal, out firstSide) && int.TryParse(secondSideVal, out secondSide) && int.TryParse(angleVal, out angle))     //Input validation
            {
                Console.WriteLine("The area of your triangle is (({0} * {1}) / 2) * Math.Sin({2}) = {3}\n", firstSide, secondSide, angle,
                    meinTriangle.GetAreaTwoSidesAndAngle(angle, firstSide, secondSide));
            }
            else
            {
                Console.WriteLine("Invalid side or angle. Please check your input and try again");
            }
        }
    }
}