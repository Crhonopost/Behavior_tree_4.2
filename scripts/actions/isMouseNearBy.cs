using BehaviorTree;
using Godot;

public partial class isMouseNearBy : BTLeaf
{
	[Export]
    private string mouseKey;

	[Export]
    private int range;
	
    public override BTState Tick(IAgent agent, BTBlackboard blackboard)
    {

        return base.Tick(agent, blackboard);
    }
}
