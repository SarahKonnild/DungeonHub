using System.Text.Json.Serialization;

namespace DungeonHub.Persistence.DataLoader.DataLoaderTypes;

public class Feature
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("level")]
    public int Level { get; set; } = 1;

    [JsonPropertyName("class")]
    public string Class { get; set; } = string.Empty;

    [JsonPropertyName("subclass")]
    public string Subclass { get; set; } = string.Empty;

    [JsonPropertyName("gain-subclass-feature")]
    public bool GainSubclassFeature { get; set; }

    [JsonPropertyName("is-subclass-feature")]
    public bool IsSubclassFeature { get; set; }
}