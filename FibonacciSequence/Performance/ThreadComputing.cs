using System;
using System.Threading;
using FibonacciSequence.Algorithms;
using FibonacciSequence.Utilities;

namespace FibonacciSequence.Performance
{
    public class ThreadComputing
    {
        private static readonly EventWaitHandle AllThreadsCompleted = new EventWaitHandle(initialState: false,
                                                                                          mode: EventResetMode.AutoReset);
        private static int _numberOfThreads;
        private readonly ulong _iteration;

        public ThreadComputing(ulong number)
        {
            Interlocked.Increment(ref _numberOfThreads);
            this._iteration = number;
        }

        public void Calculate(Func<ulong, ulong> function)  // Delegate passing
        {
            Console.WriteLine(HelperMethods.DisplayResult(iterationNumber: this._iteration,
                                                          fibonacciNumber: function(this._iteration)));
            if (Interlocked.Decrement(ref _numberOfThreads) == 0)
            {
                AllThreadsCompleted.Set();
            }
        }
    }
}
