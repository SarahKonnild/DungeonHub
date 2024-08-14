using DungeonHub.Persistence.Models.Enums;

namespace DungeonHub.Backend.DTO.Request;

/// <summary>
///     The request type for creating characters!
/// </summary>
public class CreateCharacterRequest
{
    public string Name { get; set; }
    public CharacterClass Class { get; set; }
    public int HitPoints { get; set; }
    public int Speed { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Intelligence { get; set; }
    public int Constitution { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    public List<string> SkillProficiencies { get; set; }
    
}