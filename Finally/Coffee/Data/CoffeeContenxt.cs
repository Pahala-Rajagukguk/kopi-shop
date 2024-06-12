using Coffee.Models;
using Microsoft.EntityFrameworkCore;
using Coffee.Data;

public class  CoffeeContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void 
    OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data source=Coffee.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.ApplyConfiguration(new ProductConfigurationsModel()).Seed();
    }
    
}