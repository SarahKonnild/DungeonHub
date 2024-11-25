using DungeonHub.Client.Bridge;
using Microsoft.AspNetCore.Components;

namespace DungeonHub.Client.Components.Pages;

public partial class Monster(SignalRBridge signalRBridge) : ComponentBase
{
    public List<ViewModels.Monster> LoadAllMonsters()
    {
        // var monstersList = signalRBridge.UpdateMonsterList().Wait();
        return [];
    }
}