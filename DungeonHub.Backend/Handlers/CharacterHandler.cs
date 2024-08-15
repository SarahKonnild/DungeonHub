using DungeonHub.Backend.Handlers.Interfaces;
using DungeonHub.Persistence;
using Character = DungeonHub.Backend.DTO.DTO.Character;

namespace DungeonHub.Backend.Handlers;

/// <inheritdoc />
public class CharacterHandler(DungeonHubDbContext dungeonHubDbContext) : ICharacterHandler
{
    public void CreateCharacter(Character character)
    {
        
    }
}