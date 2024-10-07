using DungeonHub.Backend.Models.Creature.Character;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DungeonHub.Backend.Repository;

public partial class Repository
{
    /// <inheritdoc />
    public void CreatePlayerCharacter(PlayerCharacter playerCharacter)
    {
        dungeonHubDbContext.PlayerCharacters.Add(playerCharacter);
        dungeonHubDbContext.SaveChanges();
    }

    /// <inheritdoc />
    public PlayerCharacter? GetPlayerCharacterById(int id)
    {
        return dungeonHubDbContext.PlayerCharacters.Find(id);
    }

    /// <inheritdoc />
    public void UpdatePlayerCharacter(PlayerCharacter updatedPlayerCharacter)
    {
        dungeonHubDbContext.Entry(updatedPlayerCharacter).State = EntityState.Modified;
        dungeonHubDbContext.SaveChanges();
    }

    /// <inheritdoc />
    public void DeletePlayerCharacter(int id)
    {
        var playerCharacter = GetPlayerCharacterById(id);
        if (playerCharacter != null)
        {
            dungeonHubDbContext.PlayerCharacters.Remove(playerCharacter);
            dungeonHubDbContext.SaveChanges();
        }
        logger.LogWarning("Tried to remove character with ID {Id}, but it was not found.", id);
    }
}