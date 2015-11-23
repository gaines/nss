using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccessDemo.Tests
{
    [TestClass]
    public class DataAccessMethodsTests
    {
        [TestMethod]
        public void TestExecuteNonQuery()
        {
            DataAccessMethods dam = new DataAccessMethods();
            int result = dam.ExecuteNonQuery("TestStudent");

            // ExecuteQuery returns 1 if it was successful
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestExecuteReader()
        {
            DataAccessMethods dam = new DataAccessMethods();

            // Run ExecuteReader to get the names of Students with an Id = 1
            List<string> result = dam.ExecuteReader(1);

            // Since Ids are unique, there should only be one Student name returned
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void TestSqlDataAdapter()
        {
            DataAccessMethods dam = new DataAccessMethods();

            // Run FillSqlDataAdapter to get a DataSet with 
            List<string> result = dam.FillSqlDataAdapter();

            // Since Ids are unique, there should only be one Student name returned
            Assert.IsTrue(result.Count > 1);
        }
    }
}
