using BehaviorTree;
using Godot;
using System.Collections.Generic;

public partial class GoToTarget : BTLeaf
{
    public override BTState Tick(IAgent agent, BTBlackboard blackboard)
    {
        var args = new KeyValuePair<string, Variant>[] {KeyValuePair.Create("target", blackboard.getValue("target"))};
		agent.executeAction(AgentActions.GO_TO,  args);
        return BTState.SUCCESS;
    }
}
