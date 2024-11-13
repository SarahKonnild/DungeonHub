using DungeonHub.Data.Models.Creature.Character;
using DungeonHub.Data.Models.Creature.Monster;

namespace DungeonHub.Data.Repository;

/// <summary>
///     Handles database interactions.
/// </summary>
public interface IRepository
{
    #region Monsters

    /// <summary>
    ///     Create a new monster.
    /// </summary>
    /// <param name="monster">The monster to save to the database.</param>
    public void CreateMonster(Monster monster);

    /// <summary>
    ///     Get a monster by ID.
    /// </summary>
    /// <param name="id">The integer ID of the monster.</param>
    /// <returns>The found monster, if any. Otherwise, null.</returns>
    public Monster? GetMonsterById(int id);
    
    /// <summary>
    ///     Update an existing monster, if it is a custom monster.
    /// </summary>
    /// <param name="updatedMonster">The updated monster object.</param>
    public void UpdateMonster(Monster updatedMonster);

    /// <summary>
    ///     Delete a monster, if it is custom.
    /// </summary>
    /// <param name="id">The ID of the monster to remove.</param>
    public void DeleteMonster(int id);

    /// <summary>
    ///     Get the list of all monsters.
    /// </summary>
    public List<Monster> GetAllMonsters();

    #endregion
    #region Player Characters

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

    #endregion
}