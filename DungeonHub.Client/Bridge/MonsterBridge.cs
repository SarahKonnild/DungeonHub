using DungeonHub.Contracts.Creature;
using Microsoft.AspNetCore.SignalR.Client;

namespace DungeonHub.Client.Bridge;

public partial class SignalRBridge
{
    private const string CreateMonsterHub = "CreateMonster";
    private const string UpdateMonsterListHub = "UpdateMonsterList";
    
    public async Task CreateMonster(MonsterContract monster)
    {
        if (IsConnected)
        {
            await _hubConnection.SendAsync(CreateMonsterHub, monster);
        }
    }

    public async Task UpdateMonsterList()
    {
        if (IsConnected)
        {
            await _hubConnection.SendAsync(UpdateMonsterListHub);
        }
    }
}