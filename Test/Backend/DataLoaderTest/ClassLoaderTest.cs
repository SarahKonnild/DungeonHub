using DungeonHub.Persistence.Models.Creature.Character;

namespace Test.Backend.DataLoaderTest;

public partial class DataLoaderTest
{
    [Fact]
    public void Should_LoadClasses_When_LoadingClasses()
    {
        // ARRANGE
        
        // ACT
        _dataLoader.LoadCharacterClasses("DataLoaderTest/TestData/classes.json");
        
        // ASSERT
        Assert.Equal(3, Queryable.Count<CharacterClass>(_dbContext.CharacterClasses));
        Assert.Equal(8, Queryable.Count<ClassDetail>(_dbContext.ClassDetails));
    }
}