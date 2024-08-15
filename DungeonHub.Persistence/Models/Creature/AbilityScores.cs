using System.ComponentModel.DataAnnotations.Schema;

namespace DungeonHub.Persistence.Models;

/// <summary>
///     Represents a character's ability scores.
/// </summary>
public class AbilityScores
{
    /// <summary>
    ///     The ID of the set of ability scores.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    /// <summary>
    ///     The character's strength score.
    /// </summary>
    public required int Strength { get; set; }
    
    /// <summary>
    ///     The character's dexterity score.
    /// </summary>
    public required int Dexterity { get; set; }
    
    /// <summary>
    ///     The character's constitution score.
    /// </summary>
    public required int Constitution { get; set; }
    
    /// <summary>
    ///     The character's intelligence score.
    /// </summary>
    public required int Intelligence { get; set; }
    
    /// <summary>
    ///     The character's wisdom score.
    /// </summary>
    public required int Wisdom { get; set; }
    
    /// <summary>
    ///     The character's charisma score.
    /// </summary>
    public required int Charisma { get; set; }
}