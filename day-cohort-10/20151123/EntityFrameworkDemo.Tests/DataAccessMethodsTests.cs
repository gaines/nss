using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityFrameworkDemo.Tests
{
    [TestClass]
    public class DataAccessMethodsTests
    {
        [TestMethod]
        public void TestAddStudent()
        {
            DataAccessMethods dam = new DataAccessMethods();
            int result = dam.AddStudent("TestStudent");

            // AddStudent returns 1 if it was successful
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestGetStudent()
        {
            DataAccessMethods dam = new DataAccessMethods();

            // Geet the Students with an Id = 1
            Student student = dam.GetStudent(1);

            Assert.AreEqual("TestStudent", student.Name);
        }

        [TestMethod]
        public void TestGetStudentList()
        {
            DataAccessMethods dam = new DataAccessMethods();

            // Gets a list of Student objects 
            List<Student> result = dam.GetStudentList();

            // Our list should contain at least one Student
            Assert.IsTrue(result.Count > 0);
        }
    }
}
