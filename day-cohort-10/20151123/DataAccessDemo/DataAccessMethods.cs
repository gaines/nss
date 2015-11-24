using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessDemo
{
    public class DataAccessMethods
    {
        private const string _connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=False;User Id=sa;Password=Access123;MultipleActiveResultSets=True";

        public int AddStudent(string nameParameter)
        {
            // Declaring our SqlConnection inside of a "using" statement ensures the connection gets closed/disposed correctly
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // The SqlCommand object holds our T-SQL code with placeholders for parameters (@ParameterName)
                SqlCommand command = new SqlCommand("INSERT Student (Name) VALUES (@NameParameter)", connection);
                // Create a SqlParameter with the correct parameter name and type (varchar = SqlDbType.Text)
                SqlParameter parameter = new SqlParameter("@NameParameter", SqlDbType.Text);
                // Set the SqlParameter value to our method parameter
                parameter.Value = nameParameter;
                // Add the SqlParameter we created to the SqlCommand.Parameters collection so it can be used
                command.Parameters.Add(parameter);

                // Open the database connection
                connection.Open();

                // ExecuteNonQuery will return an integer to indicate whether the command executed correctly
                int result = command.ExecuteNonQuery();

                return result;
            }
        }

        public Student GetStudent(int studentId)
        {
            // Lets create a variable to hold the student we're returning
            Student student = null;

            // Declaring our SqlConnection inside of a "using" statement ensures the connection gets closed/disposed correctly
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // The SqlCommand object holds our T-SQL code with placeholders for parameters (@ParameterName)
                SqlCommand cmd = new SqlCommand("SELECT Id, Name FROM Student WHERE Id = @StudentId", connection);
                // Create a SqlParameter with the correct parameter name and type (varchar = SqlDbType.Text)
                SqlParameter parameter = new SqlParameter("StudentID", SqlDbType.Int);
                // Set the SqlParameter value to our method parameter
                parameter.Value = studentId;
                // Add the SqlParameter we created to the SqlCommand.Parameters collection so it can be used
                cmd.Parameters.Add(parameter);

                // Open the database connection
                connection.Open();

                // ExecuteReader returns a DataReader object that knows how to read each record in sequence
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    // This while statement sill step through each individual record until the DataReader has reached the end of the results
                    while (dr.Read())
                    {
                        // Now that we have returned a student, lets initialize the "student" variable
                        student = new Student();
                        // The DataReader column can be specified by ordinal (ie. 0) or column name (ie. "Name")
                        student.Id = System.Int32.Parse(dr["Id"].ToString());
                        student.Name = dr["Name"].ToString();
                    }
                }
            }
            return student;
        }

        public List<Student> GetStudentList()
        {
            // Create a List of Students to hold what is returned
            List<Student> studentList = new List<Student>();

            // Declaring our SqlConnection inside of a "using" statement ensures the connection gets closed/disposed correctly
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                // The SqlDataAdapter knows how to use a Command to fill a DataSet
                SqlDataAdapter adapter = new SqlDataAdapter();

                // Our command will query all student records
                adapter.SelectCommand = new SqlCommand("SELECT * FROM Student", conn);
                // Open the database connection
                conn.Open();

                // Create a DataSet variable to hold the results
                DataSet dataSet = new DataSet();

                // The DataAdapter.Fill method puts the results in a DataSet variable
                adapter.Fill(dataSet);

                // DataSets can contain multiple tables, but we're just going to look at the rows returned in table index 0
                foreach(DataRow row in dataSet.Tables[0].Rows)
                {
                    // We need a Student object to hold the values
                    Student student = new Student();
                    student.Id = System.Int32.Parse(row["Id"].ToString());
                    student.Name = row["Name"].ToString();
                    // Lets add our student to the list
                    studentList.Add(student);
                }
            }
            return studentList;
        }
    }
}
