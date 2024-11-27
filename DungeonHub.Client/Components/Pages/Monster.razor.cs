using DungeonHub.Client.Bridge;
using Microsoft.AspNetCore.Components;

namespace DungeonHub.Client.Components.Pages;

public partial class Monster : ComponentBase
{
    // [Inject]
    // private SignalRBridge _signalRBridge { get; set; }

    private List<ViewModels.Monster> Monsters = [];

    protected override void OnInitialized()
    {
        Monsters.AddRange([new ViewModels.Monster
        {
            Name = "Ape",
            Custom = false,
            CombatRating = "1/2",
            MonsterType = "Beast"
        },
        new ViewModels.Monster
        {
            Name = "Badger",
            Custom = false,
            CombatRating = "0",
            MonsterType = "Beast"
        },
        new ViewModels.Monster
        {
            Name = "Bat",
            Custom = false,
            CombatRating = "0",
            MonsterType = "Beast"
        },
        new ViewModels.Monster
        {
            Name = "Black Bear",
            Custom = false,
            CombatRating = "1/2",
            MonsterType = "Beast"
        }
        ]);
    }

    public List<ViewModels.Monster> LoadAllMonsters()
    {
        // var monstersList = signalRBridge.UpdateMonsterList().Wait();
        return [];
    }
}