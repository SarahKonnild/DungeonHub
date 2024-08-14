namespace DungeonHub.Backend;

public static class Calculator
{
    public static int CalculateSkillModifier(int skillValue)
    {
        return Convert.ToInt32(Math.Floor((double)(skillValue - 10) / 2));
    }
}