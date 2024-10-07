using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DungeonHub.Backend.Models.Creature.Character;

public class PlayerCharacter
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public required int Id { get; set; }

    [MaxLength(250)]
    public required string Name { get; set; } = string.Empty;

    [MaxLength(250)]
    public required string Race { get; set; } = string.Empty;

    [MaxLength(250)]
    public required string Background { get; set; } = string.Empty;

    [MaxLength(250)]
    public required string Class { get; set; } = string.Empty;

    [MaxLength(250)]
    public required string Subclass { get; set; } = string.Empty;
    
    public required int Level { get; set; }

    public required int MaxHealth { get; set; }

    public required int CurrentHealth { get; set; }

    public required int TemporaryHealth { get; set; } = 0;
    
    public required int ArmorClass { get; set; }

    public required int Strength { get; set; }

    public required int Dexterity { get; set; }

    public required int Intelligence { get; set; }
    
    public required int Constitution { get; set; }
    
    public required int Wisdom { get; set; }
    
    public required int Charisma { get; set; }
    
    public required int Speed { get; set; }
}