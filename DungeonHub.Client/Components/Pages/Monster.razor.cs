using DungeonHub.Client.Bridge;
using Microsoft.AspNetCore.Components;

namespace DungeonHub.Client.Components.Pages;

public partial class Monster : ComponentBase
{
    // [Inject]
    // private SignalRBridge _signalRBridge { get; set; }
    
    public List<ViewModels.Monster> LoadAllMonsters()
    {
        // var monstersList = signalRBridge.UpdateMonsterList().Wait();
        return [];
    }
}