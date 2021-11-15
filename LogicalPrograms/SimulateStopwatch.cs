using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace LogicalPrograms
{
    public class SimulateStopwatch
    {
        public void Timer()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for(int i=0; i<100; i++)
            {
                Thread.Sleep(6);
            }
            timer.Stop();
            Console.WriteLine("The Lapsed time is : {0:hh\\:mm\\:ss}",timer.Elapsed);
        }
    }
}
