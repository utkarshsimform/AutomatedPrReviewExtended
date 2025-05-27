using System;

// TODO: Add XML documentation
public class SampleController // Renamed to PascalCase
{
    private readonly SampleService _service;
    private readonly SampleRepository _sampleRepository; // Renamed to camelCase and made readonly

    public SampleController()
    {
        _service = new SampleService();
        _sampleRepository = new SampleRepository(); // Initialize to avoid nullable warning
    }

    public void Get() // Renamed to PascalCase
    {
        var data = _service.GetData();
        Console.WriteLine(data);
    }
}
