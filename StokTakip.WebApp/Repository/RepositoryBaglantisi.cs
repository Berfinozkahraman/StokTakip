using Microsoft.EntityFrameworkCore;
using StokTakip.WebApp.Models;

namespace StokTakip.WebApp.Repository;

public class RepositoryBaglantisi : DbContext
{
    public RepositoryBaglantisi(DbContextOptions opt) : base (opt)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server =(localdb)\\MSSQLLocalDB; Database = Stok_db; Trusted_Connection=true ");
    }
    public DbSet<Product> Products { get; set; }

}
