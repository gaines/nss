using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDemo
{
    // This Entity (class) represents the data held in the Student table
    public class Student
    {
        // The Key attribute indicates that the Id field will be the Primary Key
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
