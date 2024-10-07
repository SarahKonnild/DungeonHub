using DungeonHub.Backend.Models.Creature.Character;
using Microsoft.EntityFrameworkCore;

namespace DungeonHub.Backend;

public class DungeonHubDbContext : DbContext
{
    public DbSet<PlayerCharacter> PlayerCharacters { get; set; }

    public DungeonHubDbContext()
    {
    }
    
    public DungeonHubDbContext(DbContextOptions<DungeonHubDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=dungeonHub.db");
    }
}