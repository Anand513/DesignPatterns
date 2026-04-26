using System;

namespace AdaptorPattern
{
    /// <summary>
    /// Legacy printer class with an incompatible interface.
    /// This class cannot be modified (simulates a third-party or old library).
    /// </summary>
    public class LegacyPrinter
    {
        /// <summary>
        /// Prints a message using the legacy method signature.
        /// </summary>
        /// <param name="message">The message to print.</param>
        public void PrintMessage(string message)
        {
            Console.WriteLine($"[LegacyPrinter] {message}");
        }
    }
}
