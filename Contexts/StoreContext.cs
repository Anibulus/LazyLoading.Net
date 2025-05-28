using Entities;
using Microsoft.EntityFrameworkCore;

namespace Contexts;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options)
        : base(options) { }

    public DbSet<Brand> Brands { get; set; }
    public DbSet<Product> Products { get; set; }
}
