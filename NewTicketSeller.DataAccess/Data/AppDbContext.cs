using Microsoft.EntityFrameworkCore;
using NewTicketSeller.Domain.Models;

namespace NewTicketSeller.DataAccess.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Address>()
            .HasOne(address => address.Cinema)
            .WithOne(cinema => cinema.Address)
            .HasForeignKey<Cinema>(cinema => cinema.AddressId);
    }
}
