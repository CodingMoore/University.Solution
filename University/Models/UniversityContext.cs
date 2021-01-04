using Microsoft.EntityFrameworkCore;


namespace University.Models
{
  public class UniversityContext : DbContext
  {
    public virtual DbSet<Class> Classes { get; set; }
    public DbSet<Student> Students { get; set; }

    public DbSet<ClassStudent> ClassStudent { get; set; }

    public UniversityContext(DbContextOptions options) : base(options) { }
  }
}