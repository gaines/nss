using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DemoLibrary
{
    public class Person : IStudent
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int Grade { get; set; }
    }
}
