using DungeonHub.Contracts.Creature;
using DungeonHub.Data.Models.Creature;
using DungeonHub.Data.Models.Creature.Monster;

namespace DungeonHub.Mappers.Creature;

/// <summary>
///     Maps the monster contract to model and vice versa.
/// </summary>
public static class MonsterMapper
{
    /// <summary>
    ///     Map the Monster contract to the database model.
    /// </summary>
    /// <param name="monsterContract">The contract to map.</param>
    /// <returns>The Monster model based on the contract.</returns>
    public static Monster MapToModel(this MonsterContract monsterContract)
    {
        return new Monster
        {
            Name = monsterContract.Name,
            Health = monsterContract.Health,
            ArmorClass = monsterContract.ArmorClass,
            Initiative = monsterContract.Initiative,
            Speed = monsterContract.Speed,
            Size = (CreatureSize)monsterContract.CreatureSize,
            Strength = monsterContract.Strength,
            Dexterity = monsterContract.Dexterity,
            Intelligence = monsterContract.Intelligence,
            Constitution = monsterContract.Constitution,
            Wisdom = monsterContract.Wisdom,
            Charisma = monsterContract.Charisma,
            Custom = monsterContract.Custom,
            MonsterType = (MonsterType)monsterContract.MonsterType,
            CombatRating = monsterContract.CombatRating,
            ExperiencePoints = monsterContract.ExperiencePoints
        };
    }

    /// <summary>
    ///     Map a list of Monster contracts to a list of the database models.
    /// </summary>
    /// <param name="monsterContracts">The list of monster contracts.</param>
    /// <returns>The list of database models.</returns>
    public static List<Monster> MapToModels(this List<MonsterContract> monsterContracts)
    {
        return monsterContracts.Select(MapToModel).ToList();
    }

    /// <summary>
    ///     Map the Monster model to the interface contract.
    /// </summary>
    /// <param name="monsterModel">The model to map.</param>
    /// <returns>The Monster contract based on the model.</returns>
    public static MonsterContract MapToContract(this Monster monsterModel)
    {
        return new MonsterContract
        {
            Custom = monsterModel.Custom,
            Name = monsterModel.Name,
            Health = monsterModel.Health,
            ArmorClass = monsterModel.ArmorClass,
            Speed = monsterModel.Speed,
            CreatureSize = (int)monsterModel.Size,
            Strength = monsterModel.Strength,
            Dexterity = monsterModel.Dexterity,
            Intelligence = monsterModel.Intelligence,
            Constitution = monsterModel.Constitution,
            Wisdom = monsterModel.Wisdom,
            Charisma = monsterModel.Charisma,
            ExperiencePoints = monsterModel.ExperiencePoints,
            Initiative = monsterModel.Initiative,
            CombatRating = monsterModel.CombatRating,
            MonsterType = (int)monsterModel.MonsterType,
        };
    }

    /// <summary>
    ///     Map a list of Monster models to a list of the interface contracts.
    /// </summary>
    /// <param name="monsters">The list of monsters to map.</param>
    /// <returns>The list of Monster contracts based on the models.</returns>
    public static List<MonsterContract> MapToContracts(this List<Monster> monsters)
    {
        return monsters.Select(MapToContract).ToList();
    }
}