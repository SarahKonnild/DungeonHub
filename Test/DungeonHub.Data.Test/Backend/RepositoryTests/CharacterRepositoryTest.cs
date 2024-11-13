using System.Collections;
using DungeonHub.Data.Models.Creature;
using DungeonHub.Data.Models.Creature.Character;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using NSubstitute;
using TestHelpers;

namespace DungeonHub.Data.Test.Backend.RepositoryTests;

public partial class RepositoryTest
{
    [Fact]
    public void Should_AddCharacterToDatabase_When_CreatingCharacter()
    {
        // ARRANGE
        var playerCharacter = GetNiamhPlayerCharacter();

        // ACT
        _repository.CreatePlayerCharacter(playerCharacter);

        // ASSERT
        var playerCharacters = Enumerable.ToList<PlayerCharacter>(_dungeonHubDbContext.PlayerCharacters);
        Assert.Contains(playerCharacters, x => x.Name == playerCharacter.Name);
        Assert.Single(playerCharacters);
    }

    [Fact]
    public void Should_LogWarning_When_GettingCharacterAndItDoesntExist()
    {
        // ACT
        _repository.GetPlayerCharacterById(1);

        // ASSERT
        var receivedCalls = SubstituteExtensions.ReceivedCalls<ILogger<Repository.Repository>>(_loggerMock).ToList();
        Assert.Single(receivedCalls);
        receivedCalls.First().AssertLoggedLevelAndMessage(LogLevel.Warning, "Could not find character with ID 1.");
    }

    [Fact]
    public void Should_UpdateCharacterInDatabase_When_UpdatingCharacter()
    {
        // ARRANGE
        var playerCharacter = GetNiamhPlayerCharacter();
        _dungeonHubDbContext.PlayerCharacters.Add(playerCharacter);
        _dungeonHubDbContext.SaveChanges();

        var updatedCharacter = GetNiamhPlayerCharacter();
        updatedCharacter.Id = playerCharacter.Id;
        updatedCharacter.Class = "Warlock";
        updatedCharacter.Level = 11;

        // ACT
        _repository.UpdatePlayerCharacter(updatedCharacter);

        // ASSERT
        var playerCharacters = Enumerable.ToList<PlayerCharacter>(_dungeonHubDbContext.PlayerCharacters);
        Assert.Contains(playerCharacters, x => x.Class == updatedCharacter.Class);
        Assert.Contains(playerCharacters, x => x.Level == updatedCharacter.Level);
        Assert.Contains(playerCharacters, x => x.Name == playerCharacter.Name);
        Assert.Single(playerCharacters);
    }

    [Fact]
    public void Should_LogWarning_When_UpdatingCharacterAndItDoesntExist()
    {
        // ARRANGE
        var playerCharacter = GetNiamhPlayerCharacter();
        playerCharacter.Id = 1;
        
        // ACT
        _repository.UpdatePlayerCharacter(playerCharacter);

        // ASSERT
        var receivedCalls = SubstituteExtensions.ReceivedCalls<ILogger<Repository.Repository>>(_loggerMock).ToList();
        Assert.Single(receivedCalls);
        receivedCalls.First().AssertLoggedLevelAndMessage(LogLevel.Warning, "Tried to update character with ID 1, but it was not found.");
    }

    [Fact]
    public void Should_FetchCharacterFromDatabase_When_GettingCharacter()
    {
        // ARRANGE
        var playerCharacter = GetNiamhPlayerCharacter();
        _dungeonHubDbContext.PlayerCharacters.Add(playerCharacter);
        _dungeonHubDbContext.SaveChanges();
        
        // ACT
        var fetchedCharacter = _repository.GetPlayerCharacterById(1);

        // ASSERT
        Assert.Equal(playerCharacter, fetchedCharacter);
    }

    [Fact]
    public void Should_DeleteCharacterFromDatabase_When_DeletingCharacter()
    {
        // ARRANGE
        var playerCharacter = GetNiamhPlayerCharacter();
        _dungeonHubDbContext.PlayerCharacters.Add(playerCharacter);
        _dungeonHubDbContext.SaveChanges();
        
        // ACT
        _repository.DeletePlayerCharacter(1);
        
        // ASSERT
        Assert.Empty((IEnumerable)_dungeonHubDbContext.PlayerCharacters);
    }
    
    [Fact]
    public void Should_LogWarning_When_DeletingCharacterAndItDoesntExist()
    {
        // ACT
        _repository.DeletePlayerCharacter(1);

        // ASSERT
        var receivedCalls = SubstituteExtensions.ReceivedCalls<ILogger<Repository.Repository>>(_loggerMock).ToList();
        Assert.Single(receivedCalls);
        receivedCalls.First().AssertLoggedLevelAndMessage(LogLevel.Warning, "Tried to remove character with ID 1, but it was not found.");
    }

    private static IdentityUser GetSarahIdentityUser()
    {
        return new IdentityUser
        {
            UserName = "SarahKnapp",
            Email = "not-sarahs-email@gmail.com",
            EmailConfirmed = false,
            PhoneNumber = "not-a-phone-number"
        };
    }

    private static PlayerCharacter GetNiamhPlayerCharacter()
    {
        return new PlayerCharacter
        {
            Name = "Niamh",
            Race = "Eladrin",
            Background = "Hermit",
            Class = "Druid",
            Subclass = "Circle of the Moon",
            Level = 10,
            Health = 88,
            Initiative = 2,
            Size = CreatureSize.Medium,
            CurrentHealth = 60,
            TemporaryHealth = 0,
            ArmorClass = 13,
            Strength = 10,
            Dexterity = 15,
            Intelligence = 16,
            Constitution = 12,
            Wisdom = 18,
            Charisma = 14,
            Speed = 35,
            User = GetSarahIdentityUser()
        };
    }
}