using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DungeonHub.Persistence.Models.Enums;

namespace DungeonHub.Persistence.Models;

/// <summary>
///     Represents a D&D character sheet.
/// </summary>
public class Character
{
    /// <summary>
    ///     The database ID of the character.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    /// <summary>
    ///     The name of the character.
    /// </summary>
    [MaxLength(150)]
    public required string Name { get; set; }
    
    /// <summary>
    ///     The character's class.
    /// </summary>
    public required CharacterClass Class { get; set; }

    /// <summary>
    ///     The character's level.
    /// </summary>
    public int Level { get; set; } = 1;
    
    /// <summary>
    ///     The character's armor class.
    /// </summary>
    public required int ArmorClass { get; set; }

    /// <summary>
    ///     The character's maximum hit points.
    /// </summary>
    public required int MaxHitPoints { get; set; }
    
    /// <summary>
    ///     The character's current hit points.
    /// </summary>
    public int CurrentHitPoints { get; set; }
    
    /// <summary>
    ///     The character's current temporary hit points.
    /// </summary>
    public int TemporaryHitPoints { get; set; }
    
    /// <summary>
    ///     The character's combat initiative.
    /// </summary>
    public int Initiative { get; set; }
    
    /// <summary>
    ///     The character's maximum speed.
    /// </summary>
    public required int Speed { get; set; }
    
    /// <summary>
    ///     Count how many death saves the character has failed.
    /// </summary>
    public int DeathSaveFails { get; set; }
    
    /// <summary>
    ///     Count how many death saves the character has succeeded.
    /// </summary>
    public int DeathSaveSuccesses { get; set; }
    
    /// <summary>
    ///     Indicates if the character has inspiration.
    /// </summary>
    public bool Inspiration { get; set; }

    /// <summary>
    ///     The character's proficiency bonus.
    /// </summary>
    public int ProficiencyBonus { get; set; } = 2;

    /// <summary>
    ///     The character's saving throw statistics.
    /// </summary>
    public required SavingThrows SavingThrows { get; set; }
    
    /// <summary>
    ///     The character's ability scores.
    /// </summary>
    public required AbilityScores AbilityScores { get; set; }
    
    /// <summary>
    ///     The set of character skills.
    /// </summary>
    public required CharacterSkills CharacterSkills { get; set; }
}