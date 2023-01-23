using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace UnitManager.Data;

public class UnitDbContextFactory : IDesignTimeDbContextFactory<UnitDbContext>
{
    public UnitDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<UnitDbContext>();
        optionsBuilder.UseSqlite("Data Source=unit.db");

        return new UnitDbContext(optionsBuilder.Options);
    }
}