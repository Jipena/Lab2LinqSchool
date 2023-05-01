using Lab2LinqSchool.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab2LinqSchool.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)   // Constructor
            : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
