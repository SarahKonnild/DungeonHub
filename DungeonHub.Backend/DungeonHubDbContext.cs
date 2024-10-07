using DungeonHub.Backend.Models.Creature.Character;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DungeonHub.Backend;

public class DungeonHubDbContext : IdentityDbContext<IdentityUser>
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