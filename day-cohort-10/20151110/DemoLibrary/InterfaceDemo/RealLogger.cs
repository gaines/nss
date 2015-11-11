using System;

namespace DemoLibrary
{
    public class RealLogger : ILogger
    {
        public bool Log(string message)
        {
            // Build our log entry
            string logEntry = DateTime.Now.ToString() + ": " + message;

            // Simulate an error saving new log entry to the server
            throw new Exception("Cannot connect to server.");

            // Normally this method would return true to indicate it succeeded,
            // however since we cannot connect to the server it aborts before returning.
            // Note that Visual Studio gives you a hint (green underline) to show this will never run.
            return true;
        }
    }
}
