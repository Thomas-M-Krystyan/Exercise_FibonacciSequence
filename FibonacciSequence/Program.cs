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

        private static void Main(string[] args)
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
                    // TODO: 40 numbers in ~00:00:09.000
                    // TODO: 50 numbers in ~00:18:33.000
                    ThreadComputing threadComputing = new ThreadComputing(Number);
                    threadComputing.Calculate(Fibonacci.GenerateSequence4);

                    // TODO: 40 numbers in ~00:00:33.000
                    #region Non-multithreaded invoking
                    /*for (ulong iteration = 0UL; iteration <= Number; iteration++)
                    {
                        ulong result = Fibonacci.GenerateSequence4(iteration);
                        if (iteration == Number)
                        {
                            Console.WriteLine(HelperMethods.DisplayResult(iteration, result));
                        }
                    }*/
                    #endregion
                }
            }

            HelperMethods.Separator();
            Console.WriteLine(ReturnNthFromRecursion3Algorithm);
            HelperMethods.WriteColorLine(WarningStackOverflow);
            HelperMethods.AskIfContinue();
            if (Run)
            {
                Console.WriteLine(Waiting);
                using (ThreadPerformance.Measure())
                {
                    // TODO: 4_500 numbers in ~00:00:00.015
                    ThreadComputing threadComputing = new ThreadComputing(Number);
                    threadComputing.Calculate(Fibonacci.GenerateSequence5);
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
                    // TODO #1: 4_500 numbers in ~00:00:00.062
                    // TODO #2: 4_500 numbers in ~00:00:00.078
                    // TODO #3: 4_500 numbers in ~00:00:00.078
                    // TODO #4: 8_500 numbers in ~00:00:00.078
                    // TODO #5: 8_500 numbers in ~00:00:00.140
                    // TODO #6: 500_000 numbers in ~00:00:03.790
                    Fibonacci.GenerateSequence1(Number);  // VERY FAST
                }
            }

            HelperMethods.Separator();
            Console.WriteLine(Iteration2Algorithm);
            HelperMethods.AskIfContinue();
            if (Run)
            {
                using (ThreadPerformance.Measure())
                {
                    // TODO #1: 4_500 numbers in ~00:00:00.031
                    // TODO #2: 4_500 numbers in ~00:00:00.015
                    // TODO #3: 4_500 numbers in ~00:00:00.031
                    // TODO #4: 8_500 numbers in ~00:00:00.046
                    // TODO #5: 8_500 numbers in ~00:00:00.046
                    // TODO #6: 500_000 numbers in ~00:00:03.307
                    Fibonacci.GenerateSequence2(Number);  // VERY FAST
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
                    // TODO #1: 4_500 numbers in ~00:00:00.046
                    // TODO #2: 4_500 numbers in ~00:00:00.031
                    // TODO #3: 4_500 numbers in ~00:00:00.078
                    // TODO #4: 8_500 numbers in ~00:00:00.062
                    // TODO #5: 8_500 numbers in ~00:00:00.015
                    // TODO #6: 500_000 numbers in StackOverflowException
                    Fibonacci.GenerateSequence3(Number);  // VERY FAST
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
                    // TODO #1: 40 numbers in ~00:00:24.000
                    // TODO #2: 50 numbers in ~00:51:00.000
                    for (ulong iteration = 0UL; iteration <= Number; iteration++)
                    {
                        Console.Write($"{Fibonacci.GenerateSequence4(iteration)}, ");  // VERY SLOW
                    }
                    Console.WriteLine();
                }
            }

            HelperMethods.Separator();
            Console.WriteLine(Recursion3Algorithm);
            HelperMethods.WriteColorLine(WarningStackOverflow);
            HelperMethods.AskIfContinue();
            if (Run)
            {
                using (ThreadPerformance.Measure())
                {
                    // TODO #1: 4_500 numbers in ~00:00:00.015
                    // TODO #2: 4_500 numbers in ~00:00:00.031
                    // TODO #3: 4_500 numbers in ~00:00:00.046
                    // TODO #4: 8_500 numbers in ~00:00:00.109
                    // TODO #5: 8_500 numbers in ~00:00:00.062
                    // TODO #6: 500_000 numbers in StackOverflowException
                    for (ulong iteration = 0UL; iteration <= Number; iteration++)
                    {
                        Console.Write($"{Fibonacci.GenerateSequence5(iteration)}, ");  // VERY FAST
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
