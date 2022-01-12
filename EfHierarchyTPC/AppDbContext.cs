using Microsoft.EntityFrameworkCore;
using Models.EfHierarchyTPC;
using System.Reflection;

namespace EfHierarchyTPC;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
    {
        optBuilder.UseSqlServer("Server=.;Database=EfHierarchyTPC;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}