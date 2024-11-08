using DungeonHub.Backend.Models.Creature;
using DungeonHub.Backend.Models.Creature.Monster;
using Microsoft.Extensions.Logging;
using NSubstitute;
using Test.TestExtensions;

namespace Test.Backend.RepositoryTests;

public partial class RepositoryTest
{
    [Fact]
    public void Should_AddMonsterToDatabase_When_CreatingMonster()
    {
        // ARRANGE
        var monster = GetFrog();

        // ACT
        _repository.CreateMonster(monster);

        // ASSERT
        var monsters = _dungeonHubDbContext.Monsters.ToList();
        Assert.Contains(monsters, m => m.Name == monster.Name);
        Assert.Single(monsters);
    }

    [Fact]
    public void Should_LogWarning_When_GettingMonsterAndItDoesntExist()
    {
        // ACT
        _repository.GetMonsterById(1);
        
        // ASSERT
        var receivedCalls = _loggerMock.ReceivedCalls().ToList();
        Assert.Single(receivedCalls);
        receivedCalls.First().AssertLoggedLevelAndMessage(LogLevel.Warning, "Could not find monster with ID 1.");
    }

    [Fact]
    public void Should_NotBeAbleToUpdateNotCustomMonster_When_TryingToUpdateNotCustomMonster()
    {
        // ARRANGE
        var monster = GetFrog();
        _dungeonHubDbContext.Monsters.Add(monster);
        _dungeonHubDbContext.SaveChanges();

        var updatedMonster = GetFrog();
        updatedMonster.Name = "Big Frog";
        updatedMonster.ExperiencePoints = 10000;
        updatedMonster.CombatRating = "1/2";
        updatedMonster.Size = CreatureSize.Medium;

        // ACT
        _repository.UpdateMonster(updatedMonster);

        // ASSERT
        var monsters = _dungeonHubDbContext.Monsters.ToList();
    }

    private static Monster GetFrog()
    {
        return new Monster
        {
            Name = "Frog",
            Health = 3,
            ArmorClass = 10,
            Initiative = 1,
            Speed = 20,
            Size = CreatureSize.Tiny,
            Strength = 1,
            Dexterity = 14,
            Intelligence = 1,
            Constitution = 5,
            Wisdom = 7,
            Charisma = 3,
            Custom = false,
            MonsterType = MonsterType.Beast,
            CombatRating = "0",
            ExperiencePoints = 10
        };
    }
}