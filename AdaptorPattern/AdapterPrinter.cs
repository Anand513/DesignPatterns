using System;

namespace AdaptorPattern
{
    /// <summary>
    /// Adapter that bridges <see cref="LegacyPrinter"/> to the modern <see cref="IPrinter"/> interface.
    /// Allows legacy code to work with the new system without modification.
    /// </summary>
    public class AdapterPrinter : IPrinter
    {
        private readonly LegacyPrinter _legacyPrinter;

        /// <summary>
        /// Initializes a new instance of <see cref="AdapterPrinter"/>.
        /// </summary>
        /// <param name="legacyPrinter">The legacy printer to adapt. Cannot be null.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="legacyPrinter"/> is null.</exception>
        public AdapterPrinter(LegacyPrinter legacyPrinter)
        {
            _legacyPrinter = legacyPrinter ?? throw new ArgumentNullException(nameof(legacyPrinter));
        }

        /// <inheritdoc/>
        public void Print(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Text cannot be null or empty.", nameof(text));

            _legacyPrinter.PrintMessage(text);
        }

        /// <inheritdoc/>
        public void PrintLine(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Text cannot be null or empty.", nameof(text));

            _legacyPrinter.PrintMessage(text + Environment.NewLine);
        }
    }
}
