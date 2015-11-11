using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoLibrary;

namespace NSSDemo.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TestDemoClassInit()
        {
            DemoClass newClass1 = new DemoClass();
            DemoClass newClass2 = new DemoClass("Bob");

            // This class was not initialized without a name parameter, 
            // so the Name property was never set.
            Assert.AreEqual(newClass1.Name, null);

            // This class was given a name parameter, so it has a Name.
            Assert.AreEqual(newClass2.Name, "Bob");
        }
    }
}
