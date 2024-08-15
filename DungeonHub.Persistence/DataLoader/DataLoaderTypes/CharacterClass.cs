using System.Text.Json.Serialization;

namespace DungeonHub.Persistence.DataLoader.DataLoaderTypes;

public class CharacterClass
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("hit-die")] 
    public int HitDie { get; set; } = 4;
    
    [JsonPropertyName("saving-throws")]
    public List<string> SavingThrows { get; set; } = [];
    
    [JsonPropertyName("class-details")]
    public List<ClassDetail> ClassDetails { get; set; } = [];
}