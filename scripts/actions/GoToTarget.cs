using BehaviorTree;
using Godot;
using System.Collections.Generic;

public partial class GoToTarget : BTLeaf
{
    [Export]
    private string targetKey;

    public override BTState Tick(IAgent agent, BTBlackboard blackboard)
    {
        var args = new KeyValuePair<string, Variant>[] {KeyValuePair.Create("target", blackboard.getValue(targetKey))};
		agent.executeAction(AgentActions.GO_TO,  args);
        return BTState.SUCCESS;
    }
}
