using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//Identifying the Database Schema

namespace University.Models
{
  public class UniversityContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Course> Courses { get; set; } //DBSets are new tables being created. 
    public DbSet<Student> Students { get; set; }

    public DbSet<CourseStudent> CourseStudent { get; set; }

    public UniversityContext(DbContextOptions options) : base(options) { } 
  }
}