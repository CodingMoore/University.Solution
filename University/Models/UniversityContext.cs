using Microsoft.EntityFrameworkCore;
//Identifying the Database Schema

namespace University.Models
{
  public class UniversityContext : DbContext
  {
    public virtual DbSet<Course> Courses { get; set; } //DBSets are new tables being created. 
    public DbSet<Student> Students { get; set; }

    public DbSet<CourseStudent> CourseStudent { get; set; }

    public UniversityContext(DbContextOptions options) : base(options) { } 
  }
}