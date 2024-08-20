using DungeonHub.Backend;

namespace Test.Web;

public class TestCalculator
{
    [InlineData(10, 0)]
    [InlineData(12, 1)]
    [InlineData(8, -1)]
    [InlineData(13, 1)]
    [Theory]
    public void Should_CalculateExpectedModifier_When_PassedSkillValue(int skillValue, int expectedModifier)
    {
        // ACT
        var result = Calculator.CalculateSkillModifier(skillValue);

        // ASSERT
        Assert.Equal(expectedModifier, result);
    }
}