using Microsoft.EntityFrameworkCore;


namespace Template.Models
{
  public class TemplateContext : DbContext
  {
    public virtual DbSet<Parent> Parents { get; set; }
    public DbSet<Child> Childs { get; set; }

    public TemplateContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}