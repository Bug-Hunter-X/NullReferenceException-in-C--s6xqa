# NullReferenceException in C# Example

This repository demonstrates a common error in C#: the `NullReferenceException`. This exception occurs when you attempt to access a member (property, method, etc.) of an object that has not been initialized (is null).

## The Bug

The file `Bug.cs` contains code that will throw a `NullReferenceException` under certain conditions.  The `MyProperty` integer is not initialized, and the `MyMethod()` attempts to access it before assignment, causing an exception.

## The Solution

The `BugSolution.cs` file provides a corrected version of the code. The solution involves initializing `MyProperty` with a default value before attempting to use it.   This prevents the `NullReferenceException`.

## How to reproduce the bug

1.  Clone this repository.
2.  Compile `Bug.cs` using a C# compiler.
3.  Run the compiled program.
4.  Observe the NullReferenceException.
