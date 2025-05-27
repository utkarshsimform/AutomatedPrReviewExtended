using System;

public class Demo2 // Already PascalCase
{
    /// <summary>
    /// Returns the sum of two integers.
    /// </summary>
    public int Add(int a, int b)
    {
        return a + b;
    }

    // TODO: Add XML documentation
    public void AddNumbers()
    {
        string myString = "Hello";
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        if (myString == null)
        {
            // Avoid null dereference
        }
        try
        {
            // ...existing code...
        }
        catch (Exception)
        {
            // No logging or rethrow test3
        }
        // select * from Users where password = '1234'; // Possible SQL injection, hardcoded password
        // This is commented-out code;
    }

    // Modified the NewMethod to include additional functionality
    public void NewMethod()
    {
        Console.WriteLine("This is a new method for testing line-level comments.");
        Console.WriteLine("Additional functionality added.");
        // This line is newly added for PR diff detection
        Console.WriteLine("Line-level comment detection test.");
        // Another new line for PR diff detection
        Console.WriteLine("Another line-level comment detection test.");
    }
}
