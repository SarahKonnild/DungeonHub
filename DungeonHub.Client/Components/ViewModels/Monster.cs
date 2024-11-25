using System.Text.Json.Serialization;

namespace DungeonHub.Client.Components.ViewModels;

public class Monster
{
    [JsonPropertyName("Name")]
    public string Name { get; set; }
    
    [JsonPropertyName("IsCustom")]
    public bool Custom { get; set; }
    
    [JsonPropertyName("CombatRating")]
    public string CombatRating { get; set; }
    
    [JsonPropertyName("MonsterType")]
    public string MonsterType { get; set; }
}