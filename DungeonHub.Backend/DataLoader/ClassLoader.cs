using System.Text.Json;
using DungeonHub.Persistence.DataLoader.DataLoaderTypes;
using ClassDetail = DungeonHub.Persistence.Models.Creature.Character.ClassDetail;

namespace DungeonHub.Persistence.DataLoader;

public partial class DataLoader
{
    /// <summary>
    ///     Load the character classes.
    /// </summary>
    /// <param name="filePath">The path to the file containing the classes.</param>
    public void LoadCharacterClasses(string filePath = "../Data/classes.json")
    {
        var classesJson = File.ReadAllText(filePath);
        var classesList = JsonSerializer.Deserialize<List<CharacterClass>>(classesJson)!;

        foreach (var characterClass in classesList)
        {
            var classObject = new Models.Creature.Character.CharacterClass
            {
                Name = characterClass.Name,
                HitDie = characterClass.HitDie
            };
            
            dbContext.CharacterClasses.Add(classObject);

            foreach (var classDetail in characterClass.ClassDetails)
            {
                var detailObject = new ClassDetail()
                {
                    CharacterClass = classObject,
                    Level = classDetail.Level,
                    ProficiencyBonus = classDetail.ProficiencyBonus,
                    Rages = classDetail.Rages,
                    RageDamage = classDetail.RageDamage,
                    CantripsKnown = classDetail.CantripsKnown,
                    SpellsKnown = classDetail.SpellsKnown,
                    FirstLevelSpells = classDetail.FirstLevelSpells,
                    SecondLevelSpells = classDetail.SecondLevelSpells,
                    ThirdLevelSpells = classDetail.ThirdLevelSpells,
                    FourthLevelSpells = classDetail.FourthLevelSpells,
                    FifthLevelSpells = classDetail.FifthLevelSpells,
                    SixthLevelSpells = classDetail.SixthLevelSpells,
                    SeventhLevelSpells = classDetail.SeventhLevelSpells,
                    EighthLevelSpells = classDetail.EighthLevelSpells,
                    NinthLevelSpells = classDetail.NinthLevelSpells,
                    MartialArts = classDetail.MartialArts,
                    KiPoints = classDetail.KiPoints,
                    UnarmoredMovement = classDetail.UnarmoredMovement,
                    SneakAttackDice = classDetail.SneakAttackDice,
                    SorceryPoints = classDetail.SorceryPoints,
                    InvocationsKnown = classDetail.InvocationsKnown,
                    SlotLevel = classDetail.SlotLevel
                };
                
                dbContext.ClassDetails.Add(detailObject);
            }
        }
        
        dbContext.SaveChanges();
    }
}