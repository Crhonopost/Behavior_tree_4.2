using BehaviorTree;
using Godot;
using System;

public partial class SetMousePositionTarget : BehaviorTree.BTLeaf
{
    public override BTState Tick(IAgent agent, BTBlackboard blackboard)
    {
		var mousePos = GetViewport().GetMousePosition();

		blackboard.setValue(mousePos, "target");

		return BTState.SUCCESS;
    }
}
