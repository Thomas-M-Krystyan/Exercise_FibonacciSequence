using System;
using FibonacciSequence.Algorithms;
using FibonacciSequence.Performance;
using FibonacciSequence.Utilities;
using static FibonacciSequence.Utilities.Messages;

namespace FibonacciSequence
{
    internal static class Program
    {
        // Global variables
        internal static ulong Number;
        internal static bool Run;

        internal static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Start of program
            // ----------------------------------------------------------------
            Number = HelperMethods.GetInput();

            // ----------------------------------------------------------------
            // Returning n-th element of Fibonacci sequence
            // ----------------------------------------------------------------
            HelperMethods.Separator(false);
            Console.WriteLine(ReturnNthFromIteration1Algorithm);
            HelperMethods.AskIfContinue();
            if (Run)
            {
                using (ThreadPerformance.Measure())
                {
                    Console.WriteLine(Fibonacci.Return_Nth_Element1(Number));
                }
            }

            HelperMethods.Separator();
            Console.WriteLine(ReturnNthFromIteration2Algorithm);
            HelperMethods.AskIfContinue();
            if (Run)
            {
                using (ThreadPerformance.Measure())
                {
                    Console.WriteLine(Fibonacci.Return_Nth_Element2(Number));
                }
            }

            HelperMethods.Separator();
            Console.WriteLine(ReturnNthFromRecursion1Algorithm);
            HelperMethods.WriteColorLine(WarningStackOverflow);
            HelperMethods.AskIfContinue();
            if (Run)
            {
                using (ThreadPerformance.Measure())
                {
                    Console.WriteLine(Fibonacci.Return_Nth_Element3(Number));
                }
            }

            HelperMethods.Separator();
            Console.WriteLine(ReturnNthFromRecursion2Algorithm);
            HelperMethods.WriteColorLine(WarningStackOverflow);
            HelperMethods.WriteColorLine(WarningSystemSlowdown);
            HelperMethods.AskIfContinue();
            if (Run)
            {
                Console.WriteLine(Waiting);
                using (ThreadPerformance.Measure())
                {
                    // TODO: 9 seconds for 40 numbers
                    ThreadComputing threadComputing = new ThreadComputing(Number);
                    threadComputing.Calculate();

                    // TODO: 33 seconds for 40 numbers

                    #region Non-optimal invoking
                    /*for (ulong iteration = 0UL; iteration <= Number; iteration++)
                    {
                        Fibonacci.GenerateSequence4(iteration);
                        if (iteration == Number)
                        {
                            Console.WriteLine(HelperMethods.DisplayResult(iteration, Fibonacci.GenerateSequence4(iteration)));
                        }
                    }*/
                    #endregion
                }
            }

            // ----------------------------------------------------------------
            // Displaying Fibonacci sequence
            // ----------------------------------------------------------------
            HelperMethods.Separator();
            Console.WriteLine(Iteration1Algorithm);
            HelperMethods.AskIfContinue();
            if (Run)
            {
                using (ThreadPerformance.Measure())
                {
                    Fibonacci.GenerateSequence1(Number);  // FAST
                }
            }

            HelperMethods.Separator();
            Console.WriteLine(Iteration2Algorithm);
            HelperMethods.AskIfContinue();
            if (Run)
            {
                using (ThreadPerformance.Measure())
                {
                    Fibonacci.GenerateSequence2(Number);  // FAST
                }
            }

            HelperMethods.Separator();
            Console.WriteLine(Recursion1Algorithm);
            HelperMethods.WriteColorLine(WarningStackOverflow);
            HelperMethods.AskIfContinue();
            if (Run)
            {
                using (ThreadPerformance.Measure())
                {
                    Fibonacci.GenerateSequence3(Number); // VERY FAST
                }
            }

            HelperMethods.Separator();
            Console.WriteLine(Recursion2Algorithm);
            HelperMethods.WriteColorLine(WarningStackOverflow);
            HelperMethods.WriteColorLine(WarningSystemSlowdown);
            HelperMethods.AskIfContinue();
            if (Run)
            {
                using (ThreadPerformance.Measure())
                {
                    // TODO: 23-24 seconds for 40 numbers
                    // TODO: > 51 minutes for 50 numbers
                    for (ulong iteration = 0UL; iteration <= Number; iteration++)
                    {
                        Console.Write($"{Fibonacci.GenerateSequence4(iteration)} "); // VERY SLOW
                    }
                    Console.WriteLine();
                }
            }

            // ----------------------------------------------------------------
            // End of program
            // ----------------------------------------------------------------
            Console.ReadKey();
        }
    }
}
