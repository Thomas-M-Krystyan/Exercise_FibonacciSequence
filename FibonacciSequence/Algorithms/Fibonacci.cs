using System;

namespace FibonacciSequence.Algorithms
{
    internal static class Fibonacci
    {
    #region Displaying Fibonacci sequence
        // Iteration method #1 (using temporary variable)
        internal static void GenerateSequence1(ulong iterationNumber)
        {
            // Displaying variable
            ulong displayCounter = 0UL;

            // Fibonacci variables & algorithm
            for (ulong i = 0UL, prevPrevFibonacci = 0UL, prevFibonacci = 1UL; i <= iterationNumber; i++)
            {
                Console.WriteLine($"{displayCounter}. {prevPrevFibonacci}");
                ulong sumNumbers = prevPrevFibonacci + prevFibonacci;  // Temporary variable
                prevPrevFibonacci = prevFibonacci;
                prevFibonacci = sumNumbers;

                displayCounter++;
            }
        }

        // Iteration method #2 (using temporary variable)
        internal static void GenerateSequence2(ulong iterationNumber)
        {
            // Displaying variable
            ulong displayCounter = 0UL;

            // Fibonacci variables
            ulong prevPrevFibonacci = 0UL;
            ulong prevFibonacci = 1UL;

            while (iterationNumber-- > 0UL)
            {
                Console.WriteLine($"{displayCounter}. {prevPrevFibonacci}");
                ulong tempNumber = prevPrevFibonacci;  // Temporary variable
                prevPrevFibonacci = prevFibonacci;
                prevFibonacci += tempNumber;

                displayCounter++;
            }
            Console.WriteLine($"{displayCounter}. {prevPrevFibonacci}");
        }

        // Recursion method #1 (using substitution)
        internal static void GenerateSequence3(ulong iterationNumber, ulong counter = 0UL,
                                               ulong prevPrevFibonacci = 0UL, ulong prevFibonacci = 1UL)
        {
            Console.WriteLine($"{counter}. {prevPrevFibonacci}");
            if (counter < iterationNumber)
            {
                GenerateSequence3(iterationNumber: iterationNumber, counter: counter + 1UL,
                                  prevPrevFibonacci: prevFibonacci, prevFibonacci: prevPrevFibonacci + prevFibonacci);
                
            }
        }

        // Recursion method #2 (using double step formula: F(n) = F(n-1) + F(n-2))
        internal static ulong GenerateSequence4(ulong number)
        {
            switch (number)
            {
                case 0UL:
                    return 0UL;
                case 1UL:
                    return 1UL;
                default:
                    return GenerateSequence4(number - 1UL) + GenerateSequence4(number - 2UL);
            }
        }
    #endregion

    #region Returning n-th element of Fibonacci sequence
        // Iteration method #1 (using temporary variable)
        internal static string Return_Nth_Element1(ulong iterationNumber)
        {
            string result = default(string);

            // Fibonacci variables & algorithm
            for (ulong i = 0UL, prevPrevFibonacci = 0UL, prevFibonacci = 1UL; i <= iterationNumber; i++)
            {
                if (i == iterationNumber)
                {
                    result = Utilities.HelperMethods.DisplayResult(iterationNumber: iterationNumber,
                                                                   fibonacciNumber: prevPrevFibonacci);
                }
                ulong sumNumbers = prevPrevFibonacci + prevFibonacci;  // Temporary variable
                prevPrevFibonacci = prevFibonacci;
                prevFibonacci = sumNumbers;
            }

            return result;
        }

        // Iteration method #2 (using temporary variable)
        internal static string Return_Nth_Element2(ulong iterationNumber)
        {
            // Fibonacci variables
            ulong prevPrevFibonacci = 0UL;
            ulong prevFibonacci = prevPrevFibonacci + 1UL;

            ulong counter = iterationNumber;
            while (counter > 0UL)
            {
                ulong tempNumber = prevPrevFibonacci;  // Temporary variable
                prevPrevFibonacci = prevFibonacci;
                prevFibonacci += tempNumber;

                counter--;
            }
            return Utilities.HelperMethods.DisplayResult(iterationNumber: iterationNumber,
                                                         fibonacciNumber: prevPrevFibonacci);
        }

        // Recursion method #1 (using substitution)
        internal static string Return_Nth_Element3(ulong iterationNumber, ulong counter = 0UL,
                                                   ulong prevPrevFibonacci = 0UL, ulong prevFibonacci = 1UL)
        {
            if (counter < iterationNumber)
            {
                // Fibonacci variables & algorithm
                return Return_Nth_Element3(iterationNumber: iterationNumber, counter: counter + 1UL,
                                           prevPrevFibonacci: prevFibonacci, prevFibonacci: prevPrevFibonacci + prevFibonacci);
            }
            
            return Utilities.HelperMethods.DisplayResult(iterationNumber: iterationNumber,
                                                         fibonacciNumber: prevPrevFibonacci);
        }
    #endregion
    }
}
