using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DungeonHub.Persistence.Models.Creature.Character;

public class ClassDetail
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    public required CharacterClass CharacterClass { get; set; }
    
    public required int Level { get; set; }
    
    public required int ProficiencyBonus { get; set; }
    
    public int Rages { get; set; }
    
    public int RageDamage { get; set; }
    
    public int CantripsKnown { get; set; }
    
    public int SpellsKnown { get; set; }
    
    public int FirstLevelSpells { get; set; }
    
    public int SecondLevelSpells { get; set; }
    
    public int ThirdLevelSpells { get; set; }
    
    public int FourthLevelSpells { get; set; }
    
    public int FifthLevelSpells { get; set; }
    
    public int SixthLevelSpells { get; set; }
    
    public int SeventhLevelSpells { get; set; }
    
    public int EighthLevelSpells { get; set; }
    
    public int NinthLevelSpells { get; set; }
    
    public int MartialArts { get; set; }
    
    public int KiPoints { get; set; }
    
    public int UnarmoredMovement { get; set; }
    
    public int SneakAttackDice { get; set; }
    
    public int SorceryPoints { get; set; }
    
    public int InvocationsKnown { get; set; }
    
    public int SlotLevel { get; set; }
}