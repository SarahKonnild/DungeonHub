using DungeonHub.Persistence.Models.Creature;
using DungeonHub.Persistence.Models.Creature.Character;
using Microsoft.EntityFrameworkCore;

namespace DungeonHub.Persistence;

public class DungeonHubDbContext : DbContext
{
    public DbSet<Character> Characters { get; set; }
    
    public DbSet<CharacterClass> CharacterClasses { get; set; }
    
    public DbSet<CharacterSubclass> CharacterSubclasses { get; set; }
    
    public DbSet<Feature> Features { get; set; }
    
    public DbSet<CharacterSkills> CharacterSkills { get; set; }
    
    public DbSet<AbilityScores> AbilityScores { get; set; }
    
    public DbSet<SavingThrows> SavingThrows { get; set; }
    
    public DbSet<ClassDetail> ClassDetails { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=dungeonHub.db");
    }
}