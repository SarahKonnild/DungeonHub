using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DungeonHub.Persistence.Models.Creature.Character;

public class Feature
{
    /// <summary>
    ///     The ID of the database feature.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    /// <summary>
    ///     The name of the feature.
    /// </summary>
    [MaxLength(100)]
    public required string Name { get; set; }
    
    /// <summary>
    ///     The feature's description.
    /// </summary>
    [MaxLength(3000)]
    public required string Description { get; set; }
    
    /// <summary>
    ///     The class this feature belongs to.
    /// </summary>
    public required CharacterClass Class { get; set; }

    /// <summary>
    ///     The subclass this feature belongs to. Null if standard.
    /// </summary>
    public CharacterSubclass? Subclass { get; set; } = null!;
    
    /// <summary>
    ///     Indicates if a subclass feature is gained from this feature.
    /// </summary>
    public bool GainSubclassFeature { get; set; }
    
    /// <summary>
    ///     Indicates if the feature is a subclass feature.
    /// </summary>
    public bool IsSubclassFeature { get; set; }
}