using Microsoft.EntityFrameworkCore;
using Task1_CustomerDataBase;


public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Address> Addresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Task1_CustomerDataBase;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .HasOne(c=> c.Address)
            .WithMany(a=> a.Customers)
            .HasForeignKey(c=> c.AddressId);
    }
}