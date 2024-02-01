using BehaviorTree;
using Godot;

public partial class IsMouseNear : BTCondition
{
	[Export]
	string mouseKey;
	[Export]
	float radius;
    public override BTState Tick(Node agent, BTBlackboard blackboard)
    {
		Vector2 position = (Vector2) blackboard.getValue(mouseKey);
        if(agent is Node2D agent2D){
			return (agent2D.Position - position).Length() <= radius ? BTState.SUCCESS : BTState.FAILURE;
		} else {
			return BTState.FAILURE;
		}
    }
}
