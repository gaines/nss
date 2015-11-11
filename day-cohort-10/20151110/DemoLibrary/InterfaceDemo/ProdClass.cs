using System.Collections.Generic;
namespace DemoLibrary
{
    public class ProdClass
    {
        // We use a private varaible to hold the object that knows how to create log entries.
        private ILogger _logger;

        // The constructor accepts a class that implements the ILogger interface.
        public ProdClass(ILogger logger)
        {
            // Lets store the logging object in a private variable for later use.
            _logger = logger;
        }
        public void DoSomething()
        {
            // Important business logic here that needs to be tested!
            List<decimal> receipts = new List<decimal>();
            decimal total = 0;
            for (int i = 0; i < 10; i++)
            {
                receipts.Add(i);
                total = total + i;
            }

            // This method also logs the resulting total.
            _logger.Log("Total receipts received $" + total);
        }
    }
}
