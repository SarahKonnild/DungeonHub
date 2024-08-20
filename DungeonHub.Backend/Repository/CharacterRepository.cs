using DungeonHub.Persistence.Models.Creature.Character;

namespace DungeonHub.Persistence.Repository;

public partial class Repository
{
    public void AddCharacter(Character character)
    {
        dungeonHubDbContext.Characters.Add(character);
    }
}