using System;
using AdaptorPattern;

// -------------------------------------------------------
// Adapter Pattern Demo
// The client only knows about IPrinter (modern interface).
// LegacyPrinter is hidden behind the adapter.
// -------------------------------------------------------

Console.WriteLine("=== Adapter Pattern Demo ===");
Console.WriteLine();

// Client uses IPrinter — doesn't know about LegacyPrinter at all
IPrinter printer = new AdapterPrinter(new LegacyPrinter());

// Using Print
Console.Write("Print:     ");
printer.Print("Hello from the modern interface!");

// Using PrintLine
Console.Write("PrintLine: ");
printer.PrintLine("This prints with a newline appended.");

// Demonstrating polymorphism — swap adapters without changing client code
Console.WriteLine();
Console.WriteLine("=== Swapping adapter (polymorphism demo) ===");
IPrinter anotherPrinter = new AdapterPrinter(new LegacyPrinter());
anotherPrinter.Print("Same interface, different instance — still works!");

// Null guard demo
Console.WriteLine();
Console.WriteLine("=== Null Guard Demo ===");
try
{
    IPrinter nullPrinter = new AdapterPrinter(null);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"Caught expected exception: {ex.Message}");
}
