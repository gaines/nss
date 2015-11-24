using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkDemo
{
    public class DataAccessMethods
    {
        // Since EF knows to look for a connection string with the same name as the context,
        // we can specify the connection string in our application config file (app.config)

        public int AddStudent(string studentName)
        {
            // Instead of opening a connection, we just initialize the context
            using (var context = new SchoolContext())
            {
                // Lets create a new Student entity to add
                Student student = new Student() { Name = studentName };
                // Adding a new Student object to the SchoolContext.Students collection creates a new record
                context.Students.Add(student);
                // Our new record isn't actually saved to the database until SchoolContext.SaveChanges is called
                return context.SaveChanges();
            }
        }

        public Student GetStudent(int studentId)
        {
            // Since EF will give us a Student object, lets return it
            Student student = null;
            // Instead of opening a connection, we just initialize the context
            using (var context = new SchoolContext())
            {
                // We can use LINQ to get the first student that has a matching Id
                student = context.Students.First(s => s.Id == studentId);
            }
            return student;
        }

        public List<Student> GetStudentList()
        {
            // Since EF will give us a list of Students, lets return it
            List<Student> studentList;
            // Instead of opening a connection, we just initialize the context
            using (var context = new SchoolContext())
            {
                // We can use the ToList method to return an entire list of students
                studentList = context.Students.ToList();
            }
            return studentList;
        }
    }
}
