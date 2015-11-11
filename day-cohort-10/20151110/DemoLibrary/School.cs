using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class School
    {
        List<IStudent> students { get; set; }

        public School()
        {
            students = new List<IStudent>();
        }

        public void Enroll(IStudent newStudent)
        {
            students.Add(newStudent);
        }
    }
}
