using System;

class HorribleCode
{
    static void Main() //Problem 10. This code was formatted bady. It's fixed now, no need to thank me :)   
    {
        Console.WriteLine("Hi, I am horribly a formatted program");        //Writes on the console the following line "Hi, I am horribly a formatted program"
        Console.WriteLine("Numbers and squares:");                         //Writes on the console the following line "Numbers and squares:"
        for (int i = 0; i < 10; i++)                                       //i starts at 0 and increases by 1 until it is <10
        {
            Console.WriteLine(i + " --> " + i*i);                          //Writes current value of i on the left and its square root on the right side
        }
    }
}