namespace DemoLibrary
{
    // Interfaces define what a class will look like from the outside and what it can do, but not how.
    // https://msdn.microsoft.com/en-us/library/ms173156.aspx
    public interface ILogger
    {
        // Any class that implements ILogger will have a Log method that accepts a string and returns a bool.
        bool Log(string message);
    }
}
