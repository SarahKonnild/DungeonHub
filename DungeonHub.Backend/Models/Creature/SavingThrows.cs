using System.ComponentModel.DataAnnotations.Schema;

namespace DungeonHub.Persistence.Models.Creature;

/// <summary>
///     Represents saving throw statistics.
/// </summary>
public class SavingThrows
{
    /// <summary>
    ///     The ID of the stat set.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    /// <summary>
    ///     The character's strength save modifier.
    /// </summary>
    public required int StrengthSaveModifier { get; set; }
    
    /// <summary>
    ///     Indicates if the character is proficient with strength.
    /// </summary>
    public required bool StrengthSaveProficient { get; set; }
    
    /// <summary>
    ///     The character's dexterity save modifier.
    /// </summary>
    public required int DexteritySaveModifier { get; set; }
    
    /// <summary>
    ///     Indicates if the character is proficient with dexterity.
    /// </summary>
    public required bool DexteritySaveProficient { get; set; }
    
    /// <summary>
    ///     The character's constitution save modifier.
    /// </summary>
    public required int ConstitutionSaveModifier { get; set; }
    
    /// <summary>
    ///     Indicates if the character is proficient with constitution.
    /// </summary>
    public required bool ConstitutionSaveProficient { get; set; }
    
    /// <summary>
    ///     The character's intelligence save modifier.
    /// </summary>
    public required int IntelligenceSaveModifier { get; set; }
    
    /// <summary>
    ///     Indicates if the character is proficient with intelligence.
    /// </summary>
    public required bool IntelligenceSaveProficient { get; set; }
    
    /// <summary>
    ///     The character's wisdom save modifier.
    /// </summary>
    public required int WisdomSaveModifier { get; set; }
    
    /// <summary>
    ///     Indicates if the character is proficient with wisdom.
    /// </summary>
    public required bool WisdomSaveProficient { get; set; }
    
    /// <summary>
    ///     The character's charisma save modifier.
    /// </summary>
    public required int CharismaSaveModifier { get; set; }
    
    /// <summary>
    ///     Indicates if the character is proficient with charisma.
    /// </summary>
    public required bool CharismaSaveProficient { get; set; }
}