using FictionFantasyServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FictionFantasyServer.NetCoreEntry
{
    public class DesignTimeFFDbContextFactory : IDesignTimeDbContextFactory<FFDbContext>
    {
        public FFDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FFDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Database=FictionFantasy;", b => b.MigrationsAssembly("FictionFantasyServer.NetCoreEntry"));
            return new FFDbContext(optionsBuilder.Options);
        }
    }
}