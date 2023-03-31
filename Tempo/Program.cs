using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            //create 2 stopwatches
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            
            //start crono1 timer
            crono1.Start();
            
            //pause for 500 ms crono1
            Thread.Sleep(500);
            
            //start crono 2 timer
            crono2.Start();
            
            //pause for 300ms crono2
            Thread.Sleep(300);
            
            //stop crono1
            crono1.Stop();

            //stop crono2
            crono2.Stop();
            
            //show time for each
            TimeSpan ElapsedTime1 = crono1.Elapsed;
            TimeSpan ElapsedTime2 = crono2.Elapsed;
            
            //show timer in console crono1
            string timeElapsed1 = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                ElapsedTime1.Hours, ElapsedTime1.Minutes, ElapsedTime1.Seconds, ElapsedTime1.Milliseconds / 10);
            
            //show timer in console crono2
            string timeElapsed2 = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                ElapsedTime2.Hours, ElapsedTime2.Minutes, ElapsedTime2.Seconds, ElapsedTime2.Milliseconds / 10);
            
            //show in console
            Console.WriteLine("Runtime crono1 " + timeElapsed1);
            Console.WriteLine("Runtime crono1 " + timeElapsed2);
        }
    }
}
