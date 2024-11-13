using System.ComponentModel.DataAnnotations;

namespace DungeonHub.Data.Models.Creature.Monster;

public class Monster : Creature
{
    /// <summary>
    ///     Indicates if the monster is custom-made.
    ///     If it is, it will be editable - if not, it cannot be edited.
    /// </summary>
    public bool Custom { get; init; } = false;
    
    /// <summary>
    ///     Indicates the monster's type.
    /// </summary>
    public required MonsterType MonsterType { get; set; }

    /// <summary>
    ///     The monster's combat rating.
    /// </summary>
    [MaxLength(10)]
    public required string CombatRating { get; set; }
    
    /// <summary>
    ///     The amount of experience points gained for this beast.
    /// </summary>
    public required int ExperiencePoints { get; set; }
}