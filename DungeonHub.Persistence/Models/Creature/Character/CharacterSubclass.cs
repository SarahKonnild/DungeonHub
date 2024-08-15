using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DungeonHub.Persistence.Models.Creature.Character;

public class CharacterSubclass
{
    /// <summary>
    ///     The ID of the subclass.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    /// <summary>
    ///     The name of the subclass.
    /// </summary>
    [MaxLength(100)]
    public required string Name { get; set; }
}