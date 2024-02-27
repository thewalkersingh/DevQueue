using Microsoft.EntityFrameworkCore;
using RetroRidesAPI.Models;

namespace RetroRidesAPI.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Motorcycle> Motorcycles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasDiscriminator<string>("ProductType")
            .HasValue<Car>("Car")
            .HasValue<Motorcycle>("Motorcycle");
        // Call DataSeeder to seed data
        DataSeeder.SeedData(modelBuilder);
        // Configure any additional relationships or constraints here
        base.OnModelCreating(modelBuilder);
    }
}
