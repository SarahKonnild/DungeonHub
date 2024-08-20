using System.ComponentModel.DataAnnotations.Schema;

namespace DungeonHub.Persistence.Models.Creature.Character;

public class CharacterClass
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public required int HitDie { get; set; }
    
    // todo find a good model for the save proficiencies
    
    
}