namespace Test.DataLoaderTest;

public partial class DataLoaderTest
{
    [Fact]
    public void Should_LoadClasses_When_LoadingClasses()
    {
        // ARRANGE
        
        // ACT
        _dataLoader.LoadCharacterClasses("DataLoaderTest/TestData/classes.json");
        
        // ASSERT
        Assert.Equal(3, _dbContext.CharacterClasses.Count());
        Assert.Equal(8, _dbContext.ClassDetails.Count());
    }
}