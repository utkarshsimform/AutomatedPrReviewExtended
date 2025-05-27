using System;

/// <summary>
/// A well-formed demo class for PR review.
/// </summary>
public class demo5
{
    /// <summary>
    /// Prints a message safely.
    /// </summary>
    public void PrintMessage()
    {
        try
        {
            string message = "Hello, World!";
            Console.WriteLine(message);
            // Added for PR review detection
            Console.WriteLine("Automated PR review detection line.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
