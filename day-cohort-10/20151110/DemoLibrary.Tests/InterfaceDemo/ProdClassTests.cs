using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoLibrary;

namespace DemoLibrary.Tests
{
    // The purpose of these tests are to illustrate the flexibility provided
    // by using interfaces, specifically with constructor dependency injection.
    // For another example, check out http://www.codeproject.com/Tips/794436/Constructor-Dependency-Injection-Pattern-Implement
    [TestClass]
    public class ProdClassTests
    {
        // The test below will fail because the logger can't connect to the server,
        // even though the code for DoSomething is working perfectly.
        [TestMethod]
        public void TestDoSomethingWithProdLogger()
        {
            var logger = new RealLogger();
            var prodClass = new ProdClass(logger);
            prodClass.DoSomething();
        }

        // This test fixes the problem by providing a mock implementation of the
        // ILogger class called MockLogger without having to change any code in ProdClass.
        [TestMethod]
        public void TestDoSomethingWithMockLogger()
        {
            var logger = new MockLogger();
            var prodClass = new ProdClass(logger);
            prodClass.DoSomething();
        }
    }
}