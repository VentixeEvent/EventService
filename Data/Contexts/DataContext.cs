using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<EventEntity> Events { get; set; }
    public DbSet<EventPackageEntity> Packages { get; set; }
    public DbSet<PackageEntity> EventsPackages { get; set; }
}
