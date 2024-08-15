using System.Text.Json.Serialization;

namespace DungeonHub.Persistence.DataLoader.DataLoaderTypes;

public class ClassDetail
{
    [JsonPropertyName("level")] 
    public required int Level { get; set; }

    [JsonPropertyName("proficiency-bonus")]
    public required int ProficiencyBonus { get; set; }

    [JsonPropertyName("rages")] 
    public int Rages { get; set; } = 0;

    [JsonPropertyName("rage-damage")] 
    public int RageDamage { get; set; } = 0;

    [JsonPropertyName("cantrips-known")]
    public int CantripsKnown { get; set; } = 0;
    
    [JsonPropertyName("spells-known")]
    public int SpellsKnown { get; set; } = 0;
    
    [JsonPropertyName("1st-level-spells")]
    public int FirstLevelSpells { get; set; } = 0;
    
    [JsonPropertyName("2nd-level-spells")]
    public int SecondLevelSpells { get; set; } = 0;
    
    [JsonPropertyName("3rd-level-spells")]
    public int ThirdLevelSpells { get; set; } = 0;
    
    [JsonPropertyName("4th-level-spells")]
    public int FourthLevelSpells { get; set; } = 0;
    
    [JsonPropertyName("5th-level-spells")]
    public int FifthLevelSpells { get; set; } = 0;
    
    [JsonPropertyName("6th-level-spells")]
    public int SixthLevelSpells { get; set; } = 0;
    
    [JsonPropertyName("7th-level-spells")]
    public int SeventhLevelSpells { get; set; } = 0;
    
    [JsonPropertyName("8th-level-spells")]
    public int EighthLevelSpells { get; set; } = 0;
    
    [JsonPropertyName("9th-level-spells")]
    public int NinthLevelSpells { get; set; } = 0;
    
    [JsonPropertyName("martial-arts")]
    public int MartialArts { get; set; } = 0;
    
    [JsonPropertyName("ki-points")]
    public int KiPoints { get; set; } = 0;
    
    [JsonPropertyName("unarmored-movement")]
    public int UnarmoredMovement { get; set; } = 0;
    
    [JsonPropertyName("sneak-attack-dice")]
    public int SneakAttackDice { get; set; } = 0;
    
    [JsonPropertyName("sorcery-points")]
    public int SorceryPoints { get; set; } = 0;
    
    [JsonPropertyName("invocations-known")]
    public int InvocationsKnown { get; set; } = 0;
    
    [JsonPropertyName("slot-level")]
    public int SlotLevel { get; set; } = 0;
}