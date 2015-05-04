using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Synthesis;  //No cleanup!


namespace PerfTest
{
    //String work when innecesary---> VERY VERY SLOOOW!!!!!

    class Program
    {
        static void Main()
        {
            SpeechSynthesizer voiceSynthesizer = new SpeechSynthesizer();
            Stopwatch meinStopWatch = new Stopwatch();
            meinStopWatch.Start();

            for (int perfTestLoop = 0; perfTestLoop < 10000000; perfTestLoop++)   //1 000 000
            {
            }

            meinStopWatch.Stop();
            long elapsedTime = meinStopWatch.ElapsedMilliseconds;

            Console.WriteLine(elapsedTime);     //Print first, voice after
            //voiceSynthesizer.Speak("Execution time is " + elapsedTime + " milliseconds");
        }
        
    }
}
