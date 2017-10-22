using System;
using static FibonacciSequence.Utilities.Messages;

namespace FibonacciSequence.Utilities
{
    internal static class HelperMethods
    {
        // Helper method to asking user for input (length of Fibonacci sequence)
        internal static ulong GetInput()
        {
            Console.WriteLine(QuestionUserInput);
            string userInput = Console.ReadLine();

            try
            {
                return Convert.ToUInt64(userInput != "" ? userInput : "0");
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
                return 0UL;
            }
        }

        // Helper method to preventing known runtime crashes or system slowdown
        internal static void AskIfContinue()
        {
            Program.Run = true;

            while (true)
            {
                Console.WriteLine($"{QuestionChangeNumber} ({Program.Number})? {OptionKeysToPress}");
                ConsoleKeyInfo userInput = Console.ReadKey();

                if (userInput.KeyChar == Convert.ToChar('Y'.ToString().ToLower()))
                {
                    Console.WriteLine();
                    break;
                }
                if (userInput.KeyChar == Convert.ToChar('N'.ToString().ToLower()))
                {
                    Console.WriteLine();
                    Program.Number = GetInput();
                }
                if (userInput.KeyChar == Convert.ToChar('S'.ToString().ToLower()))
                {
                    Program.Run = false;
                    break;
                }
                if (userInput.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }

        // Helper method to generating proper suffix for numbers
        private static string DetermineNumberSuffix(ulong number)
        {
            string numberSuffix;

            switch (number)
            {
                case 1:
                    numberSuffix = "st";
                    break;
                case 2:
                    numberSuffix = "nd";
                    break;
                case 3:
                    numberSuffix = "rd";
                    break;
                default:
                    numberSuffix = "th";
                    break;
            }

            return numberSuffix;
        }

        // Helper method to displaying the result as predefined string
        internal static string DisplayResult(ulong iterationNumber, ulong fibonacciNumber)
        {
            return $"{FibonacciResultPartA} {iterationNumber}{DetermineNumberSuffix(iterationNumber)}" +
                   $" {FibonacciResultPartB} {fibonacciNumber}";
        }

        // Helper method to displaying separator between algorithms
        internal static void Separator(bool waitForKey = true)
        {
            if (waitForKey)
            {
                Console.ReadKey();
            }
            Console.WriteLine(new string('-', 50));
        }

        // Helper method to displaying warning messages in red color
        internal static void WriteColorLine(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message.PadRight(Console.WindowWidth - 1));
            Console.ResetColor();
        }
    }
}
