using BehaviorTree;
using Godot;
using System.Collections.Generic;

public partial class GoToTarget : BTLeaf
{
    [Export]
    private string targetKey;

    public override BTState Tick(Node agent, BTBlackboard blackboard)
    {
        if(agent is Agent character){
            character.Target = (Vector2) blackboard.getValue(targetKey);
        }
        
        return BTState.SUCCESS;
    }
}
