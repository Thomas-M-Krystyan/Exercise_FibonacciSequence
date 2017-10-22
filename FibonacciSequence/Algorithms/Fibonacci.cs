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
            for (ulong i = 0UL, fibonacciNumber = 0UL, nextNumber = fibonacciNumber + 1UL; i <= iterationNumber; i++)
            {
                Console.WriteLine($"{displayCounter}. {fibonacciNumber}");
                ulong sumNumbers = fibonacciNumber + nextNumber;  // Temporary variable
                fibonacciNumber = nextNumber;
                nextNumber = sumNumbers;

                displayCounter++;
            }
        }

        // Iteration method #2 (using temporary variable)
        internal static void GenerateSequence2(ulong iterationNumber)
        {
            // Displaying variable
            ulong displayCounter = 0UL;

            // Fibonacci variables
            ulong fibonacciNumber = 0UL;
            ulong nextNumber = fibonacciNumber + 1UL;

            while (iterationNumber-- > 0UL)
            {
                Console.WriteLine($"{displayCounter}. {fibonacciNumber}");
                ulong tempNumber = fibonacciNumber;  // Temporary variable
                fibonacciNumber = nextNumber;
                nextNumber += tempNumber;

                displayCounter++;
            }
            Console.WriteLine($"{displayCounter}. {fibonacciNumber}");
        }

        // Recursion method #1 (using substitution)
        internal static void GenerateSequence3(ulong iterationNumber, ulong counter = 0UL,
                                               ulong fibonacciNumber = 0UL, ulong nextNumber = 1UL)
        {
            Console.WriteLine($"{counter}. {fibonacciNumber}");
            if (counter < iterationNumber)
            {
                GenerateSequence3(iterationNumber: iterationNumber, counter: counter + 1UL,
                                  fibonacciNumber: nextNumber, nextNumber: fibonacciNumber + nextNumber);
                
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
            for (ulong i = 0UL, fibonacciNumber = 0UL, nextNumber = fibonacciNumber + 1UL; i <= iterationNumber; i++)
            {
                if (i == iterationNumber)
                {
                    result = Utilities.HelperMethods.DisplayResult(iterationNumber: iterationNumber,
                                                                   fibonacciNumber: fibonacciNumber);
                }
                ulong sumNumbers = fibonacciNumber + nextNumber;  // Temporary variable
                fibonacciNumber = nextNumber;
                nextNumber = sumNumbers;
            }

            return result;
        }

        // Iteration method #2 (using temporary variable)
        internal static string Return_Nth_Element2(ulong iterationNumber)
        {
            // Fibonacci variables
            ulong fibonacciNumber = 0UL;
            ulong nextNumber = fibonacciNumber + 1UL;

            ulong counter = iterationNumber;
            while (counter > 0UL)
            {
                ulong tempNumber = fibonacciNumber;  // Temporary variable
                fibonacciNumber = nextNumber;
                nextNumber += tempNumber;

                counter--;
            }
            return Utilities.HelperMethods.DisplayResult(iterationNumber: iterationNumber,
                                                         fibonacciNumber: fibonacciNumber);
        }

        // Recursion method #1 (using substitution)
        internal static string Return_Nth_Element3(ulong iterationNumber, ulong counter = 0UL,
                                                   ulong fibonacciNumber = 0UL, ulong nextNumber = 1UL)
        {
            if (counter < iterationNumber)
            {
                // Fibonacci variables & algorithm
                return Return_Nth_Element3(iterationNumber: iterationNumber, counter: counter + 1UL,
                                           fibonacciNumber: nextNumber, nextNumber: fibonacciNumber + nextNumber);
            }
            
            return Utilities.HelperMethods.DisplayResult(iterationNumber: iterationNumber,
                                                         fibonacciNumber: fibonacciNumber);
        }
    #endregion
    }
}
