using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;          //No clean up!

namespace PerfTest
{
    //StringBuilder is slower than char array
    //BigInteger is slower than I ever imagined
    //If-else is faster than ternary operator/statement!?How and why!? 
    //Ternary statement is a blessing to all programmers worldwide
    //Why the hell do my basic implementations of the methods run faster than the integrated ones? WTF Microsoft?!
    //Foreach is slightly faster than For
    //Still haven't found a use for Do-While :(

    class PerformanceTester
    {
        static void Main()
        {
            SpeechSynthesizer voiceSynthesizer = new SpeechSynthesizer();
            Stopwatch meinStopWatch = new Stopwatch();
            meinStopWatch.Start();

            for (int perfTestLoop = 0; perfTestLoop < 1000000; perfTestLoop++)   //1 000 000
            {//Place code for testing here and clean up when done
               
            }

            Process meinProcessForRam = Process.GetCurrentProcess();
            double memoryUsedDouble = meinProcessForRam.PrivateMemorySize64;
            long memoryUsedLong = meinProcessForRam.PrivateMemorySize64;

            meinStopWatch.Stop();
            long elapsedTime = meinStopWatch.ElapsedMilliseconds;

            Console.WriteLine(elapsedTime + "ms");
            Console.WriteLine((memoryUsedLong / 1024) + "KB");
            Console.WriteLine(((memoryUsedDouble / 1024) / 1024).ToString("0.00") + "MB");     //Print first, voice after
            voiceSynthesizer.Speak("Execution time is " + elapsedTime + " milliseconds");
            voiceSynthesizer.Speak("Memory used is " + ((memoryUsedDouble/1024)/1024).ToString("0.0") + " megabytes");
        }
        //static int TypeOneMethod(int firstNum, int secondNum)    
        //{
                //For calling
        //}

        //static string TypeTwoMethod(string firstNum, string secondNum)     
        //{
        //}

    }
}
