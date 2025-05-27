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
}
