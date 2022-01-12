using EfHierarchyTPH.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EfHierarchyTPH;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contract>().ToTable("Contracts");
    }

    public DbSet<Contract> Contracts { get; set; }
    public DbSet<MobileContract> MobileContracts { get; set; }
    public DbSet<TvContract> TvContracts { get; set; }
    public DbSet<BroadBandContract> BroadBandContracts { get; set; }
}
