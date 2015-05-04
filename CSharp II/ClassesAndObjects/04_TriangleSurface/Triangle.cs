using System;

namespace _04_TriangleSurface
{
    internal class Triangle     //This class may be thrown away entirely in a final product. 
                                //I made it in order to practice classes, but the entire calculator could have been made withour extra classes in 4 or less methods
    {                           //Intially, I tried to create a working 2d triangle class with fields, properties and rules for every angle(=180 total kinda rules), side and so on and so forth,
                                //but I couldn't manage with my current skills and reading all night wasn't of much help :(
        public float GetAreaHeightAndBase(float height, float triangleBase) //Unfinished
        {
            return (triangleBase / 2) * height;
        }
        public float GetAreaThreeSides(float a, float b, float c)
        {
            float s = (a + b + c) / 2;
            float result = Convert.ToSingle(Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
            return result;
        }
        public double GetAreaTwoSidesAndAngle(float angle, float a, float b)
        {
            angle = angle * Convert.ToSingle(Math.PI / 180.0);
            return (Math.Sin(angle) * a * b) / 2.0;
        }
    }
}
