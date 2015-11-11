namespace DemoLibrary.Tests
{
    // This class is used as an alternative to ProdLogger in our unit tests
    public class MockLogger : ILogger
    {
        public bool Log(string message)
        {
            // Since we aren't testing the logger, lets just act like it worked
            return true;
        }
    }
}
