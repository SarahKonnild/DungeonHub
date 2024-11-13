namespace DungeonHub.Contracts.Creature;

public class MonsterContract
{
    /// <summary>
    ///     Indicates if the monster is custom-made.
    ///     If it is, it will be editable - if not, it cannot be edited.
    /// </summary>
    public required bool Custom { get; set; }

    /// <summary>
    ///     The name of the creature.
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    ///     The creature's initiative modifier.
    /// </summary>
    public required int Initiative { get; set; }
    
    /// <summary>
    ///     The monster's combat rating.
    /// </summary>
    public required string CombatRating { get; set; }
    
    /// <summary>
    ///     The creature's maximum available health.
    /// </summary>
    public required int Health { get; set; }
    
    /// <summary>
    ///     The creature's armor class.
    /// </summary>
    public required int ArmorClass { get; set; }
    
    /// <summary>
    ///     The creature's walking speed.
    /// </summary>
    public required int Speed { get; set; }
    
    /// <summary>
    ///     The creature's size.
    ///     0 = Tiny
    ///     1 = Small
    ///     2 = Medium
    ///     3 = Large
    ///     4 = Huge
    ///     5 = Gargantuan
    /// </summary>
    public required int CreatureSize { get; set; }
    
    /// <summary>
    ///     Indicates the monster's type.
    ///     0 = Beast
    /// </summary>
    public required int MonsterType { get; set; }
    
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
    
    /// <summary>
    ///     The amount of experience points gained for this beast.
    /// </summary>
    public required int ExperiencePoints { get; set; }
}