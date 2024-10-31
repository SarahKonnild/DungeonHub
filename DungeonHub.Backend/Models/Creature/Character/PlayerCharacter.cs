using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace DungeonHub.Backend.Models.Creature.Character;

public class PlayerCharacter : Creature
{
    #region Basic Character Information
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
    ///     The player character's current health.
    /// </summary>
    public required int CurrentHealth { get; set; }

    /// <summary>
    ///     The player character's temporary health.
    /// </summary>
    public required int TemporaryHealth { get; set; }
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