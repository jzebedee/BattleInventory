using System;
using TaleWorlds.MountAndBlade;

namespace BattleInventory;

public class SubModule : MBSubModuleBase
{
    private readonly Lazy<BattleInventoryMissionLogic> _logic = new();

    public override void OnMissionBehaviorInitialize(Mission mission)
        => mission?.AddMissionBehavior(_logic.Value);
}

public class BattleInventoryMissionLogic : MissionLogic
{

}