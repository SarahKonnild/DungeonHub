using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DungeonHub.Backend.Models.Creature;

public abstract class Creature
{
    #region Base information

    /// <summary>
    ///     Unique database-generated ID.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    /// <summary>
    ///     The name of the creature.
    /// </summary>
    [MaxLength(250)]
    public required string Name { get; set; }
    
    /// <summary>
    ///     The creature's maximum available health.
    /// </summary>
    public required int Health { get; set; }
    
    /// <summary>
    ///     The creature's armor class.
    /// </summary>
    public required int ArmorClass { get; set; }
    
    /// <summary>
    ///     The creature's initiative modifier.
    /// </summary>
    public required int Initiative { get; set; }
    
    /// <summary>
    ///     The creature's walking speed.
    /// </summary>
    public required int Speed { get; set; }
    
    /// <summary>
    ///     The creature's size.
    /// </summary>
    public required CreatureSize Size { get; set; }

    #endregion

    #region Stats

    /// <summary>
    ///     The creature's strength score.
    /// </summary>
    public required int Strength { get; set; }

    /// <summary>
    ///     The creature's dexterity score.
    /// </summary>
    public required int Dexterity { get; set; }

    /// <summary>
    ///     The creature's intelligence score.
    /// </summary>
    public required int Intelligence { get; set; }
    
    /// <summary>
    ///     The creature's constitution score.
    /// </summary>
    public required int Constitution { get; set; }
    
    /// <summary>
    ///     The creature's wisdom score.
    /// </summary>
    public required int Wisdom { get; set; }
    
    /// <summary>
    ///     The creature's charisma score.
    /// </summary>
    public required int Charisma { get; set; }

    #endregion
}