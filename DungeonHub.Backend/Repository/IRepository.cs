using DungeonHub.Backend.Models.Creature.Character;

namespace DungeonHub.Backend.Repository;

/// <summary>
///     Handles database interactions.
/// </summary>
public interface IRepository
{
    /// <summary>
    ///     Create a new player character.
    /// </summary>
    /// <param name="playerCharacter">The player character to save to the database.</param>
    public void CreatePlayerCharacter(PlayerCharacter playerCharacter);
    
    /// <summary>
    ///     Get a player character by ID.
    /// </summary>
    /// <param name="id">The integer ID of the player character.</param>
    /// <returns>The found player character, if any. Otherwise, null.</returns>
    public PlayerCharacter? GetPlayerCharacterById(int id);
    
    /// <summary>
    ///     Update an existing player character.
    /// </summary>
    /// <param name="updatedPlayerCharacter">The updated player character object.</param>
    public void UpdatePlayerCharacter(PlayerCharacter updatedPlayerCharacter);

    /// <summary>
    ///     Delete a player character.
    /// </summary>
    /// <param name="id">The ID of the player character to remove.</param>
    public void DeletePlayerCharacter(int id);
}