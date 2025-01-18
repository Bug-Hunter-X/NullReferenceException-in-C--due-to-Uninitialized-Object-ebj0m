# NullReferenceException in C# due to Uninitialized Object

This repository demonstrates a common error in C# programming: a `NullReferenceException` caused by trying to access a member of an object that hasn't been properly initialized. The `bug.cs` file shows the erroneous code, and `bugSolution.cs` provides the corrected version.  The error occurs because the `MyObject` member is never instantiated before attempting to access `MyObject.SomeProperty`.

## Reproducing the Error
1. Clone this repository.
2. Compile and run `bug.cs`.  You will get a `NullReferenceException`.

## Solution
The `bugSolution.cs` file corrects the error by initializing `MyObject` before use.