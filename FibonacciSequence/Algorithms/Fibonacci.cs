using System;
using System.Collections.Generic;

namespace FibonacciSequence.Algorithms
{
    internal static class Fibonacci
    {
    #region Displaying Fibonacci sequence
        // Iteration method #1 (using inner variables, incrementation, and temporary variable)
        internal static void GenerateSequence1(ulong iterationNumber)
        {
            // Displaying variable
            ulong displayCounter = 0UL;

            // Fibonacci variables & algorithm
            for (ulong i = 0UL, prevPrevFibonacci = 0UL, prevFibonacci = 1UL, currentFibonacci; i <= iterationNumber; i++)
            {
                Console.WriteLine($"{displayCounter}. {prevPrevFibonacci}");
                currentFibonacci = prevPrevFibonacci + prevFibonacci;  // Temporary variable
                prevPrevFibonacci = prevFibonacci;
                prevFibonacci = currentFibonacci;

                displayCounter++;
            }
        }

        // Iteration method #2 (using outer variables, decrementation, and temporary variable)
        internal static void GenerateSequence2(ulong iterationNumber)
        {
            // Displaying variable
            ulong displayCounter = 0UL;

            // Fibonacci variables
            ulong prevPrevFibonacci = 0UL;
            ulong prevFibonacci = 1UL;
            ulong currentFibonacci;

            ulong counter = iterationNumber;
            while (counter > 0UL)
            {
                Console.WriteLine(displayCounter + ". " + prevPrevFibonacci);
                currentFibonacci = prevPrevFibonacci;  // Temporary variable
                prevPrevFibonacci = prevFibonacci;
                prevFibonacci += currentFibonacci;

                displayCounter++;
                counter--;
            }
            // Display the last element
            Console.WriteLine(displayCounter + ". " + prevPrevFibonacci);
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
                // Return Fibonacci constants: 0 or 1 immediately
                case 0UL:
                    return 0UL;
                case 1UL:
                    return 1UL;
                default:
                    return GenerateSequence4(number - 1UL) + GenerateSequence4(number - 2UL);
            }
        }

        #region Memorize recursion
            private static readonly Dictionary<ulong, ulong> MemorizedResults = new Dictionary<ulong, ulong>();

            // Recursion method #3 (upgraded version by using "memorize strategy")
            internal static ulong GenerateSequence5(ulong number)
            {
                // Return Fibonacci constants: 0 or 1 immediately
                switch (number)
                {
                    case 0UL:
                        return 0UL;
                    case 1UL:
                        return 1UL;
                    default:
                        return ReturnFibonacci(number - 1UL) + ReturnFibonacci(number - 2UL);
                }
            }

            // Method to memorize results of Fibonacci calculations
            private static ulong ReturnFibonacci(ulong number)
            {
                if (MemorizedResults.ContainsKey(number))
                {
                    return MemorizedResults[number];
                }
                ulong result = GenerateSequence5(number);
                MemorizedResults.Add(number, result);

                return result;
            }
        #endregion
    #endregion

    #region Returning n-th element of Fibonacci sequence
        // Iteration method #1 (using inner variables, incrementation, and temporary variable)
        internal static string Return_Nth_Element1(ulong iterationNumber)
        {
            // Return Fibonacci constants: 0 or 1 immediately
            switch (iterationNumber)
            {
                case 0UL:
                    return Utilities.HelperMethods.DisplayResult(iterationNumber: iterationNumber, fibonacciNumber: 0UL);
                case 1UL:
                    return Utilities.HelperMethods.DisplayResult(iterationNumber: iterationNumber, fibonacciNumber: 1UL);
            }

            // Fibonacci variables & algorithm
            for (ulong i = 0UL, prevPrevFibonacci = 0UL, prevFibonacci = 1UL, currentFibonacci; i <= iterationNumber; i++)
            {
                if (i == iterationNumber)
                {
                    return Utilities.HelperMethods.DisplayResult(iterationNumber: iterationNumber,
                                                                 fibonacciNumber: prevPrevFibonacci);
                }
                currentFibonacci = prevPrevFibonacci + prevFibonacci;  // Temporary variable
                prevPrevFibonacci = prevFibonacci;
                prevFibonacci = currentFibonacci;
            }

            return default(string);
        }

        // Iteration method #2 (using outer variables, decrementation, and temporary variable)
        internal static string Return_Nth_Element2(ulong iterationNumber)
        {
            // Fibonacci variables
            ulong prevPrevFibonacci = 0UL;
            ulong prevFibonacci = 1UL;
            ulong currentFibonacci;

            // Return Fibonacci constants: 0 or 1 immediately
            switch (iterationNumber)
            {
                case 0UL:
                    return Utilities.HelperMethods.DisplayResult(iterationNumber: iterationNumber,
                                                                 fibonacciNumber: prevPrevFibonacci);
                case 1UL:
                    return Utilities.HelperMethods.DisplayResult(iterationNumber: iterationNumber,
                                                                 fibonacciNumber: prevFibonacci);
            }

            ulong counter = iterationNumber;
            while (counter > 0UL)
            {
                currentFibonacci = prevPrevFibonacci;  // Temporary variable
                prevPrevFibonacci = prevFibonacci;
                prevFibonacci += currentFibonacci;

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
