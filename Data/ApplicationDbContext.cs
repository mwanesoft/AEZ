namespace AEZ.Data;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AEZ.Models;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<ApplicationUser>().Property(u => u.FirstName).HasMaxLength(50);
        builder.Entity<ApplicationUser>().Property(u => u.LastName).HasMaxLength(50);
        builder.Entity<ApplicationUser>().Property(u => u.IsAdmin).HasDefaultValue(false);
    }
}
