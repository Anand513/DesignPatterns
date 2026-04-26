using System;

namespace AdaptorPattern
{
    /// <summary>
    /// Modern printer interface that all printer implementations must follow.
    /// </summary>
    public interface IPrinter
    {
        /// <summary>
        /// Prints the given text inline.
        /// </summary>
        /// <param name="text">The text to print.</param>
        void Print(string text);

        /// <summary>
        /// Prints the given text followed by a new line.
        /// </summary>
        /// <param name="text">The text to print.</param>
        void PrintLine(string text);
    }
}
