using System.Data.Entity;

namespace EntityFrameworkDemo
{
    // Entity Framework knows to look for a Connection String with the 
    // same name as this class since it inherits from DbContext
    public class SchoolContext : DbContext
    {
        // This is where EF will put the records it finds in the Student table
        public DbSet<Student> Students { get; set; }
    }
}
