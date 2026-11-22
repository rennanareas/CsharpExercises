# CsharpExercises

A collection of hands-on C# and .NET exercises covering language fundamentals, control flow, collections, object-oriented programming, dates and time, exception handling, file I/O, and LINQ.

## Structure

Exercises are organized by topic folders alongside a local console runner project to compile and run code locally without relying on temporary execution paths:

- `Basics/` — Data types, variables, constants, operators, functions, and control flow (`if`/`else`, `switch`, loops)
- `Collections/` — Arrays, `List<T>`, `Dictionary<TKey, TValue>`, `Queue<T>`, and `Stack<T>`
- `Oop/` — Classes, records, interfaces, abstract/sealed/static types, inheritance, polymorphism, and encapsulation
- `StringsAndParsing/` — String manipulation, slicing/ranges, and conversions (`Parse`, `TryParse`, `Convert`)
- `Dates/` — Exercises focused on `DateTime`, `DateTimeOffset`, `DateOnly`, `TimeOnly`, `TimeSpan`, time zones, and culture formatting
- `IoAndExceptions/` — Error handling with `try`/`catch` and file operations with `System.IO`
- `Linq/` — Filtering, ordering, limiting, aggregating, and querying collections

## How to Run

1. Include or reference the exercise files in the console runner project and call the target exercise method from `Program.cs`.
2. Run the project from its folder:

```bash
dotnet run
