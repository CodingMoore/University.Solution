using Microsoft.EntityFrameworkCore;


namespace University.Models
{
  public class UniversityContext : DbContext
  {
    public virtual DbSet<Class> Classes { get; set; }
    public DbSet<Child> Childs { get; set; }

    public UniversityContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}