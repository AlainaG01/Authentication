using Authentication.Models;
using Microsoft.EntityFrameworkCore;

namespace Authentication.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<UserAccount> UserAccounts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<UserAccount>().HasData(new List<UserAccount>()
        {
            new UserAccount () { Id = 1, UserName = "Alaina", Password = "Admin01", Role = "Admin" },
            new UserAccount () { Id = 2, UserName = "Juan", Password = "User02", Role = "User" }
        });
    }
}
