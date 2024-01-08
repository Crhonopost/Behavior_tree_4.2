using BehaviorTree;

public partial class SetMousePositionTarget : BTLeaf
{
    public override BTState Tick(IAgent agent, BTBlackboard blackboard)
    {
		var mousePos = GetViewport().GetMousePosition();

		blackboard.setValue(mousePos, "target");

		return BTState.SUCCESS;
    }
}
