using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Synthesis;  //No need for cleanup

namespace PerformanceTesterSimple   //I'm leaving this here just in case something needs to be tested from inside this solution. 
{
    class Test1MilLoops
    {   //Conclusions so far:
        //Selection sort                 //If is faster than Math.Min/Max
        //My implementation:             //If is not a major cause for slowdown
        //1400(Optimisable to ~1200. Still slow)
        //1406ms-->1mil
        //1401
        //1390
        //1384
        //1395
        //
        //Common one:
        //1047
        //1053
        //1060
        //1056

        //705,722,705,704   -->Version 2 of input validation
        //9067,9022,9092    -->Version 1 of input validation. Wow! What was I thinking?
        static void Main()  
        {                 
            SpeechSynthesizer voiceSynthesizer=new SpeechSynthesizer();
            Stopwatch meinStopWatch = new Stopwatch();
            meinStopWatch.Start();

            for (int perfTestLoop = 0; perfTestLoop < 100000; perfTestLoop++)   //1 000 000
            {//Input items for testing and clean up when done

            }

            meinStopWatch.Stop();
            long elapsedTime = meinStopWatch.ElapsedMilliseconds;

            Console.WriteLine(elapsedTime);     //Print first, voice after
            voiceSynthesizer.Speak("Execution time is " + elapsedTime + " milliseconds");
        }
    }
}
