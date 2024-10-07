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
        var foundCharacter = dungeonHubDbContext.PlayerCharacters.FirstOrDefault(character => character.Id == id);
        if (foundCharacter is null)
        {
            logger.LogWarning("Could not find character with ID {Id}.", id);
        }

        return foundCharacter;
    }

    /// <inheritdoc />
    public void UpdatePlayerCharacter(PlayerCharacter updatedPlayerCharacter)
    {
        var existingCharacter = dungeonHubDbContext.PlayerCharacters.Find(updatedPlayerCharacter.Id);
        if (existingCharacter != null)
        {
            dungeonHubDbContext.Entry(existingCharacter).CurrentValues.SetValues(updatedPlayerCharacter);
            dungeonHubDbContext.SaveChanges();
        }
        logger.LogWarning("Tried to update character with ID {Id}, but it was not found.", updatedPlayerCharacter.Id);
    }

    /// <inheritdoc />
    public void DeletePlayerCharacter(int id)
    {
        var playerCharacter = dungeonHubDbContext.PlayerCharacters.Find(id);
        if (playerCharacter != null)
        {
            dungeonHubDbContext.PlayerCharacters.Remove(playerCharacter);
            dungeonHubDbContext.SaveChanges();
        }
        logger.LogWarning("Tried to remove character with ID {Id}, but it was not found.", id);
    }
}