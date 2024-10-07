using DungeonHub.Backend.Models.Creature.Character;
using Microsoft.EntityFrameworkCore;

namespace DungeonHub.Backend;

public class DungeonHubDbContext : DbContext
{
    public DbSet<PlayerCharacter> PlayerCharacters { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=dungeonHub.db");
    }
}