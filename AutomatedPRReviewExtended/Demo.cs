using System;

// This file is for PR review demo and intentionally contains issues
public class Demo // Renamed to PascalCase
{
    // TODO: Refactor this method before merging
    public void PrintMessage() // Renamed to PascalCase
    {
        string message = ""; // Renamed to camelCase and initialized
        Console.WriteLine(message); // Removed possible null dereference
        Console.WriteLine("This is a new line for PR line comment detection.");
        // int x = 5;
    }
}
