using System;
using System.Diagnostics;
using System.IO;
namespace LogicalPrograming
{
    public class StopWatch
    {
        public static void FindStopWatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Fibonacci.FindFibonacciNumber();
            stopwatch.Stop();
            Console.WriteLine("\nTime Elapsed : {0}", stopwatch.Elapsed);
        }
    }
}