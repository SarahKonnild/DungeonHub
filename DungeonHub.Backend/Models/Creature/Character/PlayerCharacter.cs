using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace DungeonHub.Backend.Models.Creature.Character;

public class PlayerCharacter
{
    #region Basic Character Information

    /// <summary>
    ///     Unique database-generated ID.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    ///     The name of the player character.
    /// </summary>
    [MaxLength(250)]
    public required string Name { get; set; } = string.Empty;

    /// <summary>
    ///     The player character's race.
    /// </summary>
    [MaxLength(250)]
    public required string Race { get; set; } = string.Empty;

    /// <summary>
    ///     The player character's background.
    /// </summary>
    [MaxLength(250)]
    public required string Background { get; set; } = string.Empty;

    /// <summary>
    ///     The player character's class.
    /// </summary>
    [MaxLength(250)]
    public required string Class { get; set; } = string.Empty;

    /// <summary>
    ///     The player character's subclass.
    /// </summary>
    [MaxLength(250)]
    public required string Subclass { get; set; } = string.Empty;
    
    /// <summary>
    ///     The player character's level.
    /// </summary>
    public required int Level { get; set; }

    /// <summary>
    ///     The player character's maximum available health.
    /// </summary>
    public required int MaxHealth { get; set; }

    /// <summary>
    ///     The player character's current health.
    /// </summary>
    public required int CurrentHealth { get; set; }

    /// <summary>
    ///     The player character's temporary health.
    /// </summary>
    public required int TemporaryHealth { get; set; }
    
    /// <summary>
    ///     The player character's armor class.
    /// </summary>
    public required int ArmorClass { get; set; }
    
    /// <summary>
    ///     The player character's movement speed.
    /// </summary>
    public required int Speed { get; set; }
    
    #endregion

    #region Character Stats
    /// <summary>
    ///     The player character's strength score.
    /// </summary>
    public required int Strength { get; set; }

    /// <summary>
    ///     The player character's dexterity score.
    /// </summary>
    public required int Dexterity { get; set; }

    /// <summary>
    ///     The player character's intelligence score.
    /// </summary>
    public required int Intelligence { get; set; }
    
    /// <summary>
    ///     The player character's constitution score.
    /// </summary>
    public required int Constitution { get; set; }
    
    /// <summary>
    ///     The player character's wisdom score.
    /// </summary>
    public required int Wisdom { get; set; }
    
    /// <summary>
    ///     The player character's charisma score.
    /// </summary>
    public required int Charisma { get; set; }
    
    #endregion

    #region Character Metadata

    /// <summary>
    ///     The user the character belongs to.
    /// </summary>
    public required IdentityUser User { get; set; }
    
    /// <summary>
    ///     The time and date the character was created.
    /// </summary>
    public DateTime Created { get; set; }
    
    /// <summary>
    ///     The time and date the character was last modified.
    /// </summary>
    public DateTime Modified { get; set; }

    #endregion
}