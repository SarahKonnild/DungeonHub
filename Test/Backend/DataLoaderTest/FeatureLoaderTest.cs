

using DungeonHub.Persistence.Models.Creature.Character;

namespace Test.Backend.DataLoaderTest;

public partial class DataLoaderTest
{
    [Fact]
    public void Should_LoadFeatures_When_LoadingFeatures()
    {
        // ARRANGE
        _dbContext.CharacterClasses.AddRange([
            new CharacterClass
            {
                Name = "Class1",
                HitDie = 6
            },
            new CharacterClass
            {
                Name = "Class2",
                HitDie = 8
            },
            new CharacterClass
            {
                Name = "Class3",
                HitDie = 8
            }
        ]);
        _dbContext.CharacterSubclasses.Add(new CharacterSubclass
        {
            Name = "Subclass1"
        });
        _dbContext.SaveChanges();

        // ACT
        _dataLoader.LoadFeatures("DataLoaderTest/TestData/class-feature.json");
        
        // ASSERT
        Assert.Equal(3, _dbContext.Features.Count());
    }
}