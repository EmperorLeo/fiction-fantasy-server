using FictionFantasyServer.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FictionFantasyServer.Data
{
    public class FFDbContext : DbContext
    {
        public FFDbContext(DbContextOptions<FFDbContext> options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<BookEntity> Books { get; set; }
        public DbSet<CharacterEntity> Characters { get; set; }
        public DbSet<NationalitiesEntity> Nationalities { get; set; }
        public DbSet<SettingsEntity> Settings { get; set; }
        public DbSet<SpeciesEntity> Species { get; set; }
    }
}