using DungeonHub.Backend.Handlers.Interfaces;
using DungeonHub.Persistence;
using DungeonHub.Persistence.Models;
using DungeonHub.Persistence.Models.Enums;
using Character = DungeonHub.Backend.DTO.DTO.Character;

namespace DungeonHub.Backend.Handlers;

/// <inheritdoc />
public class CharacterHandler(DungeonHubDbContext dungeonHubDbContext) : ICharacterHandler
{
    public void CreateCharacter(Character character)
    {
        // Create ability scores
        var abilityScores = new AbilityScores
        {
            Strength = character.Strength,
            Dexterity = character.Dexterity,
            Constitution = character.Constitution,
            Intelligence = character.Intelligence,
            Wisdom = character.Wisdom,
            Charisma = character.Charisma,
        };
        
        // Create character skills
        
        
        var dbCharacter = new Persistence.Models.Character
        {
            Name = character.Name,
            Class = character.Class,
            ArmorClass = character.ArmorClass,
            MaxHitPoints = character.HitPoints,
            CurrentHitPoints = character.HitPoints,
            TemporaryHitPoints = 0,
            Initiative = 0,
            Speed = 0,
            SavingThrows = null,
            AbilityScores = abilityScores,
            CharacterSkills = null
        };
    }
}