using DungeonHub.Backend.Models.Creature;
using DungeonHub.Backend.Models.Creature.Character;
using DungeonHub.Backend.Models.Creature.Monster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DungeonHub.Backend;

public class DungeonHubDbContext : IdentityDbContext<IdentityUser>
{
    public DbSet<PlayerCharacter> PlayerCharacters { get; set; }
    public DbSet<Monster> Monsters { get; set; }

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

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<IdentityUserLogin<string>>().HasKey(login => new { login.LoginProvider, login.ProviderKey });
        builder.Entity<IdentityUserRole<string>>().HasKey(role => new { role.UserId, role.RoleId });
        builder.Entity<IdentityUserToken<string>>().HasKey(token => new { token.UserId, token.LoginProvider, token.Name });
        
        builder.Entity<Creature>().UseTpcMappingStrategy();
    }
}