using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EfCorePopulateCollectionProblem;

public class TestDbContext : DbContext
{
    public DbSet<EntityOne> EntityOnes { get; set; }
    public DbSet<EntityTwo> EntityTwos { get; set; }
    public DbSet<EntityTwo> EntityThrees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Server=127.0.0.1,1433;Initial Catalog=XXX;User Id=XXX;Password=XXX")
            .EnableSensitiveDataLogging()
            .LogTo(Console.WriteLine, LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}