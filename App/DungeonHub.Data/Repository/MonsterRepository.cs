using DungeonHub.Data.Models.Creature.Monster;
using Microsoft.Extensions.Logging;

namespace DungeonHub.Data.Repository;

public partial class Repository
{
    /// <inheritdoc />
    public void CreateMonster(Monster monster)
    {
        dungeonHubDbContext.Monsters.Add(monster);
        dungeonHubDbContext.SaveChanges();
    }

    /// <inheritdoc />
    public Monster? GetMonsterById(int id)
    {
        var foundMonster = dungeonHubDbContext.Monsters.FirstOrDefault(monster => monster.Id == id);
        if (foundMonster is null)
        {
            logger.LogWarning("Could not find monster with ID {Id}.", id);
        }
        
        return foundMonster;
    }

    /// <inheritdoc />
    public void UpdateMonster(Monster updatedMonster)
    {
        var existingMonster = dungeonHubDbContext.Monsters.Find(updatedMonster.Id);
        if (existingMonster is { Custom: true })
        {
            dungeonHubDbContext.Entry(existingMonster).CurrentValues.SetValues(updatedMonster);
            dungeonHubDbContext.SaveChanges();
        }
        logger.LogWarning("Tried to update monster with ID {Id}, but it was not found or is not custom.", updatedMonster.Id);
    }

    /// <inheritdoc />
    public void DeleteMonster(int id)
    {
        var monster = dungeonHubDbContext.Monsters.Find(id);
        if (monster is null || !monster.Custom)
        {
            logger.LogWarning("Tried to remove monster with ID {Id}, but it was not found or is not custom.", id);
            return;
        }
        dungeonHubDbContext.Monsters.Remove(monster);
        dungeonHubDbContext.SaveChanges();
    }
}