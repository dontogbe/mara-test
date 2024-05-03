using Microsoft.EntityFrameworkCore;

namespace Mara.Models;

public class MaraContext : DbContext
{
    public MaraContext(DbContextOptions<MaraContext> options)
        : base(options)
    {
    }

    public DbSet<Item> Items { get; set; } = null!;
}