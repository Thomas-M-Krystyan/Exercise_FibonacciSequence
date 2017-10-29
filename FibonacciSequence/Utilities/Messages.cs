namespace FibonacciSequence.Utilities
{
    internal static class Messages
    {
        // Questions
        internal const string QuestionUserInput = "Type a length of Fibonacci sequence to display:";
        internal const string QuestionChangeNumber = "Do you want to continue calculations with your pre-selected number";
        internal const string OptionKeysToPress = "\n(Y)es to continue, (N)o to change, (S)kip to pass, (Esc)ape to exit:";

        // Informations
        internal const string Iteration1Algorithm = "Implementation of iteration #1 Fibonacci algorithm: temporary variable, i++\n";
        internal const string Iteration2Algorithm = "Implementation of iteration #2 Fibonacci algorithm: temporary variable, i--\n";
        internal const string Recursion1Algorithm = "Implementation of recursion #1 Fibonacci algorithm: parameters substitution\n";
        internal const string Recursion2Algorithm = "Implementation of recursion #2 Fibonacci algorithm: F(n) = F(n-1) + F(n-2)\n";
        internal const string Recursion3Algorithm = "Implementation of recursion #3 Fibonacci algorithm: memorizing equations\n";
        internal const string ReturnNthFromIteration1Algorithm = "Return n-th element from iteration #1 algorithm: temporary variable, i++\n";
        internal const string ReturnNthFromIteration2Algorithm = "Return n-th element from iteration #2 algorithm: temporary variable, i--\n";
        internal const string ReturnNthFromRecursion1Algorithm = "Return n-th element from recursion #1 algorithm: parameters substitution\n";
        internal const string ReturnNthFromRecursion2Algorithm = "Return n-th element from recursion #2 algorithm: F(n) = F(n-1) + F(n-2)\n";
        internal const string ReturnNthFromRecursion3Algorithm = "Return n-th element from recursion #3 algorithm: memorizing equations\n";
        internal const string Waiting = "\nCalculating...\n";

        // Warnings
        internal const string WarningStackOverflow = "WARNING: possible StackOverflowException!\n";
        internal const string WarningSystemSlowdown = "WARNING: progressively runtime slowdown!\n";

        // Monits
        internal const string FibonacciResultPartA = "The";
        internal const string FibonacciResultPartB = "number of Fibonacci sequence is:";
    }
}
