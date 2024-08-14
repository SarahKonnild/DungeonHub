using DungeonHub.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace DungeonHub.Persistence;

public class DungeonHubDbContext : DbContext
{
    public DbSet<Character> Characters { get; set; }
    
    public DbSet<CharacterSkills> CharacterSkills { get; set; }
    
    public DbSet<AbilityScores> AbilityScores { get; set; }
    
    public DbSet<SavingThrows> SavingThrows { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=dungeonHub.db");
    }
}