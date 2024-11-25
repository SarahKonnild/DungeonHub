using DungeonHub.Contracts.Creature;
using DungeonHub.Data.Repository;
using DungeonHub.Mappers.Creature;
using Microsoft.AspNetCore.SignalR;

namespace DungeonHub.SignalR;

/// <summary>
///     The SignalR Hub for anything to do with Monsters.
/// </summary>
/// <param name="repository">The IRepository instance for accessing the database.</param>
public class MonsterHub(IRepository repository) : Hub
{
    /// <summary>
    ///     Create a monster in the database.
    /// </summary>
    /// <param name="monster">The monster to save.</param>
    public async Task CreateMonster(MonsterContract monster)
    {
        var monsterModel = monster.MapToModel();
        repository.CreateMonster(monsterModel);
        await UpdateMonsterList();
    }

    private async Task UpdateMonsterList()
    {
        var monstersList = repository.GetAllMonsters().MapToContracts();
        await Clients.All.SendAsync("UpdateMonsters", monstersList);
    }
}