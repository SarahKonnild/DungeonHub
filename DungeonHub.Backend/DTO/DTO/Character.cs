using System.Text.Json.Serialization;

namespace DungeonHub.Backend.DTO.DTO;

public class Character
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("hit-points")]
    public int HitPoints { get; set; }
    
    [JsonPropertyName("armor-class")]
    public int ArmorClass { get; set; }
    
    [JsonPropertyName("speed")]
    public int Speed { get; set; }
    
    [JsonPropertyName("strength")]
    public int Strength { get; set; }
    
    [JsonPropertyName("dexterity")]
    public int Dexterity { get; set; }
    
    [JsonPropertyName("constitution")]
    public int Constitution { get; set; }
    
    [JsonPropertyName("intelligence")]
    public int Intelligence { get; set; }
    
    [JsonPropertyName("wisdom")]
    public int Wisdom { get; set; }
    
    [JsonPropertyName("charisma")]
    public int Charisma { get; set; }

    [JsonPropertyName("skill-proficiencies")]
    public List<string> SkillProficiencies { get; set; } = [];
}