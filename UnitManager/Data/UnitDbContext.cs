using Microsoft.EntityFrameworkCore;
using UnitManager.Models;

namespace UnitManager.Data;

public class UnitDbContext : DbContext
{
    public UnitDbContext(DbContextOptions<UnitDbContext> options)
        : base(options)
    {
    }

    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }*/

    public DbSet<Unit> Units { get; set; }
    public DbSet<Rank> Ranks { get; set; }
    public DbSet<UnitMember> UnitMembers { get; set; }
    public DbSet<Position> Positions { get; set; }
}